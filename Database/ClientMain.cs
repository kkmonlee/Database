using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZedGraph;

namespace Database
{
    public partial class ClientMain : Form
    {
        int i = 1;
        private string Sql;
        private OleDbConnection connection;
        private OleDbDataAdapter oledbAdapter;
        #region "Variable declarations"
        public string usernamestringo;
        public string passwordstringo;
        private readonly string[] exerciseTypeRange = {"Cycling", "Running", "Swimming"};

        private readonly string[] cyclingStyleRange = {
            "<10 mph, leisure cycling", "10 - 11.9 mph, gentle", "12 - 13.9 mph, moderate", "14 - 15.9 mph, vigorous",
            "16 - 20 mph, very fast", ">20 mph, racing"
        };

        private readonly string[] runningSpeedRange = {"5 mph", "6 mph", "7 mph", "8 mph", "9 mph", "10 mph"};

        private readonly string[] swimmingStyleRange = {"Freestyle, slow", "Freestyle, fast", "Backstroke", "Breaststroke", "Butterfly"};
        #endregion

        public ClientMain()
        {
            
            InitializeComponent();
            exerciseTypeComboBox.SelectedIndexChanged += exerciseTypeComboBox_SelectedIndexChanged;
            exerciseTypeComboBox.Items.AddRange(exerciseTypeRange);

            //Login signin = new Login(ident);
            //signin.Show();


        }
        #region "Update tab args"
        private void BT_ClientSave_Click(object sender, EventArgs e)
        {
            try
            {


                string height = TB_ClientHeight.Text;
                string weight = TB_ClientWeight.Text;
                string name = TB_ClientName.Text;
                string bday = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                int heightint = Convert.ToInt32(height);
                int weightint = Convert.ToInt32(weight);
                // MessageBox.Show(bdint.ToString());
   
                usernamestringo = Login.UsernameFromLogin;
                passwordstringo = Login.passwordFromLogin;
                
                
                using (OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False"))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    string query =
                        "UPDATE TPersons SET [Name]=@Name, Height=@Height, Weight=@Weight, Bday=@Bday " + " WHERE UserName= @username";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Height", heightint.ToString());
                    cmd.Parameters.AddWithValue("@Weight", weightint.ToString());
                    cmd.Parameters.AddWithValue("@Bday", bday);
                    cmd.Parameters.AddWithValue("@username", usernamestringo);
                    
                    cmd.Connection = myCon;
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.Parameters.Clear();
                }

                

            }
            catch (OleDbException exception)
            {
                string errorMessages = "";
                for (int i = 0; i < exception.Errors.Count; i++)
                {
                    var oleDbError = exception.Errors[i];
                    if (oleDbError != null)
                        errorMessages += "Index #" + i + "\n" +
                                         "NativeError: " + oleDbError.NativeError + "\n" +
                                         "Source: " + oleDbError.Source + "\n" +
                                         "SQLState: " + oleDbError.SQLState + "\n" +
                                         "Description: " + oleDbError.Message + "\n" +
                                         "Please consult with the software developer.";
                }
                MessageBox.Show(errorMessages);
            }
        }
        #endregion
        private void ClientMain_Load(object sender, EventArgs e)
        {
            //var loginForm = new Login();
            ////loginForm.Close();
            ////can't close parent form from child, will try to make it invisible
            //loginForm.Visible = false;
            exerciseStyleComboBox.Enabled = false;

            // Running labels
            RunningSession1.Visible = false;
            RunningSession2.Visible = false;
            RunningSession3.Visible = false;
            RunningCalories1.Visible = false;
            RunningCalories2.Visible = false;
            RunningCalories3.Visible = false;
            RunningTotalCalories.Visible = false;

            // Cycling labels
            CyclingSession1.Visible = false;
            CyclingSession2.Visible = false;
            CyclingSession3.Visible = false;
            CyclingCalories1.Visible = false;
            CyclingCalories2.Visible = false;
            CyclingCalories3.Visible = false;
            CyclingTotalCalories.Visible = false;

            // Swimming labels
            SwimmingSession1.Visible = false;
            SwimmingSession2.Visible = false;
            SwimmingSession3.Visible = false;
            SwimmingCalories1.Visible = false;
            SwimmingCalories2.Visible = false;
            SwimmingCalories3.Visible = false;
            SwimmingTotalCalories.Visible = false;



            //try
            //{
            //    string tableName = usernamestringo + "_SESSIONS";
            //    string cntPath = System.IO.Directory.GetCurrentDirectory();
            //    using (OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" + usernamestringo.ToLower() + "_LOG.accdb;"))
            //    using (OleDbCommand cmd = new OleDbCommand())
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        string query = "UPDATE " + tableName + " SET [UserName]=@username";
            //    }
            //}
            //catch
            //{

            //}
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TB_Duration.Text = string.Concat(TB_Duration.Text.Where(char.IsDigit));
            // form validation, stops from entering anything else other than digits
        }

        private void exerciseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = exerciseTypeComboBox.SelectedItem as string;
            // converts the item in the combo box ie. the sport to a string and then uses that to change the
            // options for the second combobox :)
            exerciseStyleComboBox.Enabled = true;
            switch (selectedValue)
            {
                case  "Cycling":
                    exerciseStyleComboBox.Items.Clear();
                    exerciseStyleComboBox.Items.AddRange(cyclingStyleRange);
                    break;

                case "Running":
                    exerciseStyleComboBox.Items.Clear();
                    exerciseStyleComboBox.Items.AddRange(runningSpeedRange);
                    break;

                case "Swimming":
                    exerciseStyleComboBox.Items.Clear();
                    exerciseStyleComboBox.Items.AddRange(swimmingStyleRange);
                    break;
            }
            
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            #region "Reset button args
            SessiondateTimePicker.ResetText();
            hourComboBox.SelectedIndex = -1;
            minuteComboBox.SelectedIndex = -1;
            TB_Duration.Text = null;
            exerciseStyleComboBox.SelectedIndex = -1;
            exerciseTypeComboBox.SelectedIndex = -1;
            #endregion

        }

        private void BT_Log_Click(object sender, EventArgs e)
        {
            try
            {
                #region "Log tab args"
                #region "Declaring/testing variables

                usernamestringo = Login.UsernameFromLogin;
                string tableName = usernamestringo + "_SESSIONS";
                string date = SessiondateTimePicker.Value.ToString("dd-MM-yyyy");
                //string hourTime = hourComboBox.SelectedIndex.ToString();
                int hourTime = int.Parse(hourComboBox.SelectedItem.ToString());
                
                // BUG: hourTime returns value of (hour - 1)
                // BUG FIXED: parsed hourTime as an integer

                int minuteTime = int.Parse(minuteComboBox.SelectedItem.ToString());

                // check where the problem is
                //MessageBox.Show(hourTime + " " + minuteTime);
                int duration = int.Parse(TB_Duration.Text);
                string exerciseType = exerciseTypeComboBox.SelectedItem.ToString();
                string exerciseStyle = exerciseStyleComboBox.SelectedItem.ToString();

                //MessageBox.Show("Date " + date + "\n" +
                //                "Time: " + hourTime + ":" + minuteTime + "\n" +
                //                "Duration: " + duration + "\n" +
                //                "Exercise Type: " + exerciseType + "\n" +
                //                "Exercise Style: " + exerciseStyle + "\n");
                #endregion

                #region "Adding session into log"
                //int id = i + 1;
                

                var exerciseTypeQuery = "[" + exerciseType + "]";
                var totalTime = hourTime + ":" + minuteTime;
                var insertQuery = " || " + date + " | " + totalTime + " | " + duration + " | " + exerciseStyle;
                // string query = "UPDATE " + tableName + " SET " + exerciseTypeQuery + "=@exerciseQueries" + " WHERE UserName=@username";
                // MessageBox.Show(query + "\n" + insertQuery + "\n" + exerciseTypeQuery + "\n" + totalTime + "\n" + usernamestringo + "\n ^ name");

                string otherExercise1 = null;
                string otherExercise2 = null;
                switch (exerciseTypeQuery)
                {
                    case "[Cycling]":
                        otherExercise1 = "[Running]";
                        otherExercise2 = "[Swimming]";
                        break;
                    case "[Running]":
                        otherExercise1 = "[Cycling]";
                        otherExercise2 = "[Swimming]";
                        break;
                    case "[Swimming]":
                        otherExercise1 = "[Running]";
                        otherExercise2 = "[Cycling]";
                        break;
                }
                const string empty = "";
                string cntPath = Directory.GetCurrentDirectory();
                using (OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" + usernamestringo.ToLower() + "_LOG.accdb;"))
                using (OleDbCommand cmd = new OleDbCommand())
                {


                    i++;

                    cmd.CommandType = CommandType.Text;
                    string query = "INSERT INTO " + tableName + " (" + exerciseTypeQuery + ", [ID], [UserName], " + otherExercise1 + "," + otherExercise2 + ") VALUES(@exerciseTypeQuery, @id, @username, @unusedExercise1, @unusedExercise2)";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@exerciseTypeQuery", insertQuery);
                    cmd.Parameters.AddWithValue("@id", i.ToString());
                    cmd.Parameters.AddWithValue("@username", usernamestringo);
                    cmd.Parameters.AddWithValue("@unusedExercise1", empty);
                    cmd.Parameters.AddWithValue("@unusedExercise2", empty);

                    cmd.Connection = myCon;
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Your record has been logged in!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.Parameters.Clear();

                }
                #endregion


            }
            catch (OleDbException exception)
            {
                string errorMessages = "";
                for (int i = 0; i < exception.Errors.Count; i++)
                {
                    var oleDbError = exception.Errors[i];
                    if (oleDbError != null)
                        errorMessages += "Index #" + i + "\n" +
                                         "NativeError: " + oleDbError.NativeError + "\n" +
                                         "Source: " + oleDbError.Source + "\n" +
                                         "SQLState: " + oleDbError.SQLState + "\n" +
                                         "Description: " + oleDbError.Message + "\n \n" +
                                         "Please consult with the software developer.";
                }
                MessageBox.Show(errorMessages);
            }

                #endregion
        }

        //public List<string> ParseWords(string s)
        //{
        //    List<string> words = new List<string>();

        //    int pos = 0;
        //    while (pos < s.Length)
        //    {
        //        //word start
        //        int start = pos;

        //        //word  end
        //        pos.s.IndexOf('|', pos);

        //    }
        //    return words;
        //} 


        private void button1_Click(object sender, EventArgs e)
        {
            string cntPath = Directory.GetCurrentDirectory();
            usernamestringo = Login.UsernameFromLogin;
            string tableName = usernamestringo + "_SESSIONS";

            List<string> rawList = new List<string>();
            //int a;
            //int b;
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" + usernamestringo.ToLower() + "_LOG.accdb;");
            Sql = "SELECT * FROM " + tableName;
            
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(Sql, connection);

                DataSet dsSet = new DataSet();
                oledbAdapter.Fill(dsSet);
                foreach (DataRow row in dsSet.Tables[0].Rows)
                {
                    rawList.Add(row["Running"].ToString());
                }
                
                // convert List<string> to single string
                
                var show = String.Join(null, rawList.ToArray());
                //label10.Text = show;

                //var showSplit = Regex.Split(show, " \\| ");
                // replaced by SplitIt
                var doubleVBarSplit = Regex.Split(show, " \\|\\| "); // splits separate sessions
                string dateSplit;
                string timeSplit;
                int duraSplit;
                string typeSplit;
                int calories;
                int totalCalories = 0;
                /*
                 * Do bottom
                 */
                int i;
                i = 1;
                if (i < doubleVBarSplit.Length)
                {
                    var session1 = doubleVBarSplit[1];
                    var SplitIt1 = Regex.Split(session1, " \\| ");
                    dateSplit = DateTime.Parse(s: SplitIt1[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt1[1]);
                    duraSplit = int.Parse(SplitIt1[2]);
                    typeSplit = string.Concat(SplitIt1[3]);
                    RunningSession1.Visible = true;
                    RunningCalories1.Visible = true;
                    RunningTotalCalories.Visible = true;
                    RunningSession1.Text = "Date: " + dateSplit + "\n " +
                                   "Time: " + timeSplit + "\n " +
                                   "Duration: " + duraSplit + "\n " +
                                   "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "5 mph")
                    {
                        calories = 472*duraSplit;
                        RunningCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "6 mph")
                    {
                        calories = 590*duraSplit;
                        RunningCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "7 mph")
                    {
                        calories = 679*duraSplit;
                        RunningCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "8 mph")
                    {
                        calories = 797*duraSplit;
                        RunningCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "9 mph")
                    {
                        calories = 885 * duraSplit;
                        RunningCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "10 mph")
                    {
                        calories = 944*duraSplit;
                        RunningCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        Exception ex = null;
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    label11.Text = "There are no logs! \n Try again.";
                    foreach (var source in doubleVBarSplit.Skip(1))
                    {
                        
                    }
                }
                


                
                /*
                 * Do bottom
                 */
                i = 2;
                if (i < doubleVBarSplit.Length)
                {
                    var session2 = doubleVBarSplit[2];
                    var SplitIt2 = Regex.Split(session2, " \\| ");
                    dateSplit = DateTime.Parse(SplitIt2[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt2[1]);
                    duraSplit = int.Parse(SplitIt2[2]);
                    typeSplit = string.Concat(SplitIt2[3]);
                    RunningSession2.Visible = true;
                    RunningCalories2.Visible = true;
                    RunningTotalCalories.Visible = true;
                    RunningSession2.Text = "Date: " + dateSplit + "\n " +
                                    "Time: " + timeSplit + "\n " +
                                    "Duration: " + duraSplit + "\n " +
                                    "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "5 mph")
                    {
                        calories = 472 * duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "6 mph")
                    {
                        calories = 590 * duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "7 mph")
                    {
                        calories = 679 * duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "8 mph")
                    {
                        calories = 797 * duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "9 mph")
                    {
                        calories = 885 * duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "10 mph")
                    {
                        calories = 944 * duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        Exception ex = null;
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    foreach (var source in doubleVBarSplit.Skip(2))
                    {
                        
                    }
                }

                i = 3;
                if (i < doubleVBarSplit.Length)
                {
                    var session3 = doubleVBarSplit[3];
                    var SplitIt3 = Regex.Split(session3, " \\| ");
                    dateSplit = DateTime.Parse(SplitIt3[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt3[1]);
                    duraSplit = int.Parse(SplitIt3[2]);
                    typeSplit = string.Concat(SplitIt3[3]);
                    RunningSession3.Visible = true;
                    RunningCalories3.Visible = true;
                    RunningTotalCalories.Visible = true;
                    RunningSession3.Text = "Date: " + dateSplit + "\n " +
                                    "Time: " + timeSplit + "\n " +
                                    "Duration: " + duraSplit + "\n " +
                                    "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "5 mph")
                    {
                        calories = 472 * duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "6 mph")
                    {
                        calories = 590 * duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "7 mph")
                    {
                        calories = 679 * duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "8 mph")
                    {
                        calories = 797 * duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "9 mph")
                    {
                        calories = 885 * duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "10 mph")
                    {
                        calories = 944 * duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        Exception ex = null;
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    foreach (var source in doubleVBarSplit.Skip(3))
                    {
                        
                    }
                }
                RunningTotalCalories.Text += @" calories burnt in total";


                /*
                 *  Do bottom
                 */

                // can only view 3 sessions per sport per person as they will be resting afterwards




                //string parsed = ""; // where parsed  string will be stored

                //bool flag = false;
                //foreach (var x in show.Split('|'))
                //{
                //    bool endsWithVBAR = x.EndsWith(@"\");
                //    parsed += flag ? "|" + x + " " : endsWithVBAR ? x.Substring(0, x.Length - 1) : x + " ";
                //    flag = endsWithVBAR;
                //    textBox1.Text = parsed;
                //}

                //string[] events = Regex.Split(show, "\\|");

                //foreach (string line in events)
                //{
                //    textBox1.Text = line;
                //}


                /*
                String.Join(String.Empty, rawList.ToArray());
                StringBuilder builder = new StringBuilder();
                rawList.ForEach(s => builder.Append(s));
                string display = rawList.Aggregate<string>((a, b) => a + b);
                MessageBox.Show(display);
                 */

            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            connection.Close();
            connection.Dispose();
        }

        private void CyclingView_Click(object sender, EventArgs e)
        {
            string cntPath = Directory.GetCurrentDirectory();
            usernamestringo = Login.UsernameFromLogin;
            string tableName = usernamestringo + "_SESSIONS";

            List<string> rawList = new List<string>();
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" + usernamestringo.ToLower() + "_LOG.accdb;");
            Sql = "SELECT * FROM " + tableName;

            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(Sql, connection);
                // BEFORE: oledbAdapter = new OleDbDataAdapter();
                // WAS GETTING ERROR: SelectCommand.Connection property has not been initialized.
                // I had to pass the connection object on the adapter.
                DataSet dsSet = new DataSet();
                oledbAdapter.Fill(dsSet);
                foreach (DataRow row in dsSet.Tables[0].Rows)
                {
                    rawList.Add(row["Cycling"].ToString());

                }

                var show = String.Join(null, rawList.ToArray());
                var doubleVBarSplit = Regex.Split(show, " \\|\\| ");
                string dateSplit;
                string timeSplit;
                int duraSplit;
                string typeSplit;
                int calories;
                int totalCalories = 0;

                //Session 1
                int i;
                i = 1;
                if (i < doubleVBarSplit.Length)
                {
                    var session1 = doubleVBarSplit[1];
                    var SplitIt1 = Regex.Split(session1, " \\| ");
                    dateSplit = DateTime.Parse(s: SplitIt1[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt1[1]);
                    duraSplit = int.Parse(SplitIt1[2]);
                    typeSplit = string.Concat(SplitIt1[3]);
                    CyclingSession1.Visible = true;
                    CyclingCalories1.Visible = true;
                    CyclingTotalCalories.Visible = true;
                    CyclingSession1.Text = "Date: " + dateSplit + "\n " +
                                           "Time: " + timeSplit + "\n " +
                                           "Duration: " + duraSplit + "\n " +
                                           "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "<10 mph, leisure cycling")
                    {
                        calories = 236*duraSplit;
                        CyclingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "10 - 11.9 mph, gentle")
                    {
                        calories = 354*duraSplit;
                        CyclingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "12 - 13.9 mph, moderate")
                    {
                        calories = 472*duraSplit;
                        CyclingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "14 - 15.9 mph, vigorous")
                    {
                        calories = 590*duraSplit;
                        CyclingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "16 - 20 mph, very fast")
                    {
                        calories = 708*duraSplit;
                        CyclingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == ">20 mph, racing")
                    {
                        calories = 944*duraSplit;
                        CyclingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        Exception ex = null;
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    label10.Text = "There are no logs! \n Try again.";
                    foreach (var source in doubleVBarSplit.Skip(1))
                    {
                        
                    }
                }
                CyclingTotalCalories.Text = "You have burnt " + totalCalories + " calories.";

                // Session 2
                i = 2;
                if (i < doubleVBarSplit.Length)
                {
                    var session2 = doubleVBarSplit[2];
                    var SplitIt2 = Regex.Split(session2, " \\| ");
                    dateSplit = DateTime.Parse(SplitIt2[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt2[1]);
                    duraSplit = int.Parse(SplitIt2[2]);
                    typeSplit = string.Concat(SplitIt2[3]);
                    CyclingSession2.Visible = true;
                    CyclingCalories2.Visible = true;
                    CyclingTotalCalories.Visible = true;
                    CyclingSession2.Text = "Date: " + dateSplit + "\n " +
                                           "Time: " + timeSplit + "\n " +
                                           "Duration: " + duraSplit + "\n " +
                                           "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "<10 mph, leisure cycling")
                    {
                        calories = 236*duraSplit;
                        CyclingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "10 - 11.9 mph, gentle")
                    {
                        calories = 354*duraSplit;
                        CyclingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "12 - 13.9 mph, moderate")
                    {
                        calories = 472*duraSplit;
                        CyclingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "14 - 15.9 mph, vigorous")
                    {
                        calories = 590*duraSplit;
                        CyclingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "16 - 20 mph, very fast")
                    {
                        calories = 708*duraSplit;
                        CyclingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == ">20 mph, racing")
                    {
                        calories = 944*duraSplit;
                        CyclingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        Exception ex = null;
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    foreach (var source in doubleVBarSplit.Skip(2))
                    {
                        
                    }
                }
                CyclingTotalCalories.Text = "You have burnt " + totalCalories + " calories.";

                // Session3
                i = 3;
                if (i < doubleVBarSplit.Length)
                {
                    var session3 = doubleVBarSplit[3];
                    var SplitIt3 = Regex.Split(session3, " \\| ");
                    dateSplit = DateTime.Parse(SplitIt3[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt3[1]);
                    duraSplit = int.Parse(SplitIt3[2]);
                    typeSplit = string.Concat(SplitIt3[3]);
                    CyclingSession3.Visible = true;
                    CyclingCalories3.Visible = true;
                    CyclingTotalCalories.Visible = true;
                    CyclingSession3.Text = "Date: " + dateSplit + "\n " +
                                           "Time: " + timeSplit + "\n " +
                                           "Duration: " + duraSplit + "\n " +
                                           "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "<10 mph, leisure cycling")
                    {
                        calories = 236*duraSplit;
                        CyclingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "10 - 11.9 mph, gentle")
                    {
                        calories = 354*duraSplit;
                        CyclingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "12 - 13.9 mph, moderate")
                    {
                        calories = 472*duraSplit;
                        CyclingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "14 - 15.9 mph, vigorous")
                    {
                        calories = 590*duraSplit;
                        CyclingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "16 - 20 mph, very fast")
                    {
                        calories = 708*duraSplit;
                        CyclingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == ">20 mph, racing")
                    {
                        calories = 944*duraSplit;
                        CyclingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        CyclingTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        Exception ex = null;
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    foreach (var source in doubleVBarSplit.Skip(3))
                    {
                        
                    }
                }
                CyclingTotalCalories.Text = "You have burnt " + totalCalories + " calories.";

            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            connection.Close();
            connection.Dispose();
        }

        private void BT_SwimmingView_Click(object sender, EventArgs e)
        {
            string cntPath = Directory.GetCurrentDirectory();
            usernamestringo = Login.UsernameFromLogin;
            string tableName = usernamestringo + "_SESSIONS";

            List<string> rawList = new List<string>();
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" + usernamestringo.ToLower() + "_LOG.accdb;");
            Sql = "SELECT * FROM " + tableName;

            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(Sql, connection);
                DataSet dsSet = new DataSet();
                oledbAdapter.Fill(dsSet);
                foreach (DataRow row in dsSet.Tables[0].Rows)
                {
                    rawList.Add(row["Swimming"].ToString());
                }
                var show = String.Join(null, rawList.ToArray());
                var doubleVBarSplit = Regex.Split(show, " \\|\\| ");
                string dateSplit;
                string timeSplit;
                int duraSplit;
                string typeSplit;
                int calories;
                int totalCalories = 0;

                // Session 1
                int i;
                i = 1;
                if (i < doubleVBarSplit.Length)
                {
                    var session1 = doubleVBarSplit[1];
                    var SplitIt1 = Regex.Split(session1, " \\| ");
                    dateSplit = DateTime.Parse(s: SplitIt1[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt1[1]);
                    duraSplit = int.Parse(SplitIt1[2]);
                    typeSplit = string.Concat(SplitIt1[3]);
                    SwimmingSession1.Visible = true;
                    SwimmingCalories1.Visible = true;
                    SwimmingTotalCalories.Visible = true;
                    SwimmingSession1.Text = "Date: " + dateSplit + "\n " +
                                            "Time: " + timeSplit + "\n " +
                                            "Duration: " + duraSplit + "\n " +
                                            "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "Freestyle, slow")
                    {
                        calories = 413*duraSplit;
                        SwimmingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Freestyle, fast")
                    {
                        calories = 590*duraSplit;
                        SwimmingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Backstroke")
                    {
                        calories = 413*duraSplit;
                        SwimmingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Breastroke")
                        // BUG: Breaststroke spelled wrong.
                    {
                        calories = 590*duraSplit;
                        SwimmingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Butterfly")
                    {
                        calories = 649*duraSplit;
                        SwimmingCalories1.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        //Exception ex = null;
                        //MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    label12.Text = "There are no logs! \n Try again.";
                    foreach (var source in doubleVBarSplit.Skip(1))
                    {
                        
                    }
                }
                SwimmingTotalCalories.Text = "You have burnt " + totalCalories + " calories.";

                // Session 2
                i = 2;
                if (i < doubleVBarSplit.Length)
                {
                    var session2 = doubleVBarSplit[2];
                    var SplitIt2 = Regex.Split(session2, " \\| ");
                    dateSplit = DateTime.Parse(SplitIt2[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt2[1]);
                    duraSplit = int.Parse(SplitIt2[2]);
                    typeSplit = string.Concat(SplitIt2[3]);
                    SwimmingSession2.Visible = true;
                    SwimmingCalories2.Visible = true;
                    SwimmingTotalCalories.Visible = true;
                    SwimmingSession2.Text = "Date: " + dateSplit + "\n " +
                                            "Time: " + timeSplit + "\n " +
                                            "Duration: " + duraSplit + "\n " +
                                            "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "Freestyle, slow")
                    {
                        calories = 413*duraSplit;
                        SwimmingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Freestyle, fast")
                    {
                        calories = 590*duraSplit;
                        SwimmingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Backstroke")
                    {
                        calories = 413*duraSplit;
                        SwimmingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Breastroke")
                    {
                        calories = 590*duraSplit;
                        SwimmingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Butterfly")
                    {
                        calories = 649*duraSplit;
                        SwimmingCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        //Exception ex = null;
                        //MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    foreach (var source in doubleVBarSplit.Skip(2))
                    {
                        
                    }
                }
                SwimmingTotalCalories.Text = "You have burnt " + totalCalories + " calories.";

                // Session 3
                i = 3;
                if (i < doubleVBarSplit.Length)
                {
                    var session3 = doubleVBarSplit[3];
                    var SplitIt3 = Regex.Split(session3, " \\| ");
                    dateSplit = DateTime.Parse(SplitIt3[0]).ToShortDateString();
                    timeSplit = string.Concat(SplitIt3[1]);
                    duraSplit = int.Parse(SplitIt3[2]);
                    typeSplit = string.Concat(SplitIt3[3]);
                    SwimmingSession3.Visible = true;
                    SwimmingCalories3.Visible = true;
                    SwimmingTotalCalories.Visible = true;
                    SwimmingSession3.Text = "Date: " + dateSplit + "\n " +
                                            "Time: " + timeSplit + "\n " +
                                            "Duration: " + duraSplit + "\n " +
                                            "Type: " + typeSplit + "\n \n ";
                    if (typeSplit == "Freestyle, slow")
                    {
                        calories = 413*duraSplit;
                        SwimmingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Freestyle, fast")
                    {
                        calories = 590*duraSplit;
                        SwimmingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Backstroke")
                    {
                        calories = 413*duraSplit;
                        SwimmingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Breastroke")
                    {
                        calories = 590*duraSplit;
                        SwimmingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    if (typeSplit == "Butterfly")
                    {
                        calories = 649*duraSplit;
                        SwimmingCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        SwimmingTotalCalories.Text = totalCalories.ToString();
                    }
                    else
                    {
                        //Exception ex = null;
                        //MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    foreach (var source in doubleVBarSplit.Skip(3))
                    {
                        
                    }
                }
                SwimmingTotalCalories.Text = "You have burnt " + totalCalories + " calories.";
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.ToString());
                
            }
            connection.Close();
            connection.Dispose();
        }

    }
}
