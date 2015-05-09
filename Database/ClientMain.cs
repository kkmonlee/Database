using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Database
{
    public partial class ClientMain : Form
    {
        private OleDbConnection connection;
        // Creating an instance of the OleDbConnection
        private int i = 1;
        // Declaring i with the value 1
        private OleDbDataAdapter oledbAdapter;
        // Creating an instance of the OleDbDataAdapter
        private string Sql;
        // Declaring a string which will be used as the ADO.NET command in the future

        public ClientMain()
        {
            InitializeComponent();
            exerciseTypeComboBox.SelectedIndexChanged += exerciseTypeComboBox_SelectedIndexChanged;
            // Value in the dropdown box should be added into this
            exerciseTypeComboBox.Items.AddRange(exerciseTypeRange);
            // Value in the dropdown box will be replaced to the string array exerciseTypeRange

            //Login signin = new Login(ident);
            //signin.Show();
        }

        #region "Update tab args"

        private void BT_ClientSave_Click(object sender, EventArgs e)
        {
            try
            {
                var height = TB_ClientHeight.Text;
                var weight = TB_ClientWeight.Text;
                var name = TB_ClientName.Text;
                // Assigning the strings to their textbox values
                var bday = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                // Will convert the DateTimePicker value to string in the form of "dd-mm-yyyy"
                var heightint = Convert.ToInt32(height);
                // Will convert the string to an integer
                var weightint = Convert.ToInt32(weight);
                // Will convert the string to an integer
                // MessageBox.Show(bdint.ToString());

                usernamestringo = Login.UsernameFromLogin;
                //passwordstringo = Login.passwordFromLogin;


                using (
                    var myCon =
                        new OleDbConnection(
                            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False")
                    )
                // myCon is an instance of the OleDbConnection with an assigned connection address
                using (var cmd = new OleDbCommand())
                // Using the above connection, do this :
                {
                    cmd.CommandType = CommandType.Text;
                    const string query = "UPDATE TPersons SET [Name]=@Name, Height=@Height, Weight=@Weight, Bday=@Bday " +
                                         " WHERE UserName= @username";
                    // ADO.NET command
                    cmd.CommandText = query;
                    // The command is the query
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Height", heightint.ToString());
                    cmd.Parameters.AddWithValue("@Weight", weightint.ToString());
                    cmd.Parameters.AddWithValue("@Bday", bday);
                    cmd.Parameters.AddWithValue("@username", usernamestringo);
                    // Assigning all the verbatim strings to their values
                    cmd.Connection = myCon;
                    // Declaring using a command that myCon is the connection
                    myCon.Open();
                    // Open the connection
                    cmd.ExecuteNonQuery();
                    // Execute the query command
                    MessageBox.Show("Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Show success message
                    cmd.Parameters.Clear();
                    // Clear (null) the verbatim strings
                }
            }
            catch (OleDbException exception)
            // If there is an error then...
            {
                var errorMessages = "";
                for (var i = 0; i < exception.Errors.Count; i++)
                // For every exception:
                {
                    var oleDbError = exception.Errors[i];
                    if (oleDbError != null)
                        errorMessages += "Index #" + i + "\n" +
                                         "NativeError: " + oleDbError.NativeError + "\n" +
                                         "Source: " + oleDbError.Source + "\n" +
                                         "SQLState: " + oleDbError.SQLState + "\n" +
                                         "Description: " + oleDbError.Message + "\n" +
                                         "Please consult with the software developer.";
                // Generate an exception string
                }
                MessageBox.Show(errorMessages);
                // And print it
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
            var selectedValue = exerciseTypeComboBox.SelectedItem as string;
            // converts the item in the combo box ie. the sport to a string and then uses that to change the
            // options for the second combobox :)
            exerciseStyleComboBox.Enabled = true;
            switch (selectedValue)
            {
                case "Cycling":
                    exerciseStyleComboBox.Items.Clear();
                    exerciseStyleComboBox.Items.AddRange(cyclingStyleRange);
                    break;
                // If user has selected Cycling then the bottom dropdown box must show cycling-compatible exercise styles

                case "Running":
                    exerciseStyleComboBox.Items.Clear();
                    exerciseStyleComboBox.Items.AddRange(runningSpeedRange);
                    break;
                // If user has selected Running then the bottom dropdown box must show running-compatible exercise styles

                case "Swimming":
                    exerciseStyleComboBox.Items.Clear();
                    exerciseStyleComboBox.Items.AddRange(swimmingStyleRange);
                    break;
                // If user has selected Swimming then the bottom dropdown box must show swimming-compatible exercise styles
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
            // Resets and blanks all the textboxes and dropdown boxes
            #endregion
        }

        private void BT_Log_Click(object sender, EventArgs e)
        {
            try
            {
                #region "Log tab args"

                #region "Declaring/testing variables

                usernamestringo = Login.UsernameFromLogin;
                // Uses the username value from the login form to search the logs
                var tableName = usernamestringo + "_SESSIONS";
                // Names the table with the username
                // Example: John_SESSIONS
                var date = SessiondateTimePicker.Value.ToString("dd-MM-yyyy");
                // Converts the DateTime to a string in the form of "dd-mm-yyyy"
                //string hourTime = hourComboBox.SelectedIndex.ToString();
                var hourTime = int.Parse(hourComboBox.SelectedItem.ToString());
                // Parses the hour combo box to an integer


                // BUG: hourTime returns value of (hour - 1)
                // BUG FIXED: parsed hourTime as an integer

                var minuteTime = int.Parse(minuteComboBox.SelectedItem.ToString());
                // Parses the minute combo box to an integer

                // check where the problem is
                //MessageBox.Show(hourTime + " " + minuteTime);
                var duration = int.Parse(TB_Duration.Text);
                // Parses the duration textbox to an integer
                var exerciseType = exerciseTypeComboBox.SelectedItem.ToString();
                var exerciseStyle = exerciseStyleComboBox.SelectedItem.ToString();
                // Converts the selected item in the comboboxes to strings

                //MessageBox.Show("Date " + date + "\n" +
                //                "Time: " + hourTime + ":" + minuteTime + "\n" +
                //                "Duration: " + duration + "\n" +
                //                "Exercise Type: " + exerciseType + "\n" +
                //                "Exercise Style: " + exerciseStyle + "\n");

                #endregion

                #region "Adding session into log"

                //int id = i + 1;


                var exerciseTypeQuery = "[" + exerciseType + "]";
                // Encapsulates the exercise type to make it compatible with ADO.NET
                var totalTime = hourTime + ":" + minuteTime;
                // Combines the hour and minute and separates it with a colon
                var insertQuery = " || " + date + " | " + totalTime + " | " + duration + " | " + exerciseStyle;
                // This will go into the cell. It is separated by a double pipe in the beginning so that any more entries don't confuse the program
                // Each element is also separated by one pipe

                // string query = "UPDATE " + tableName + " SET " + exerciseTypeQuery + "=@exerciseQueries" + " WHERE UserName=@username";
                // MessageBox.Show(query + "\n" + insertQuery + "\n" + exerciseTypeQuery + "\n" + totalTime + "\n" + usernamestringo + "\n ^ name");

                string otherExercise1 = null;
                string otherExercise2 = null;
                switch (exerciseTypeQuery)
                {
                // We need the other 2 unused exercise values, to find this we have to make a case statement
                    case "[Cycling]":
                        otherExercise1 = "[Running]";
                        otherExercise2 = "[Swimming]";
                        break;
                    // When the exercise chosen is Cycling then the other two are Running and Swimming.
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
                // An empty string to put this where no data is going
                var cntPath = Directory.GetCurrentDirectory();
                // Declares a local directory
                using (
                    var myCon =
                        new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" +
                                            usernamestringo.ToLower() + "_LOG.accdb;"))
                // Makes a connection to the local path with the lowercase username + "_LOG.accdb"
                using (var cmd = new OleDbCommand())
                // Using the OleDbCommand
                {
                    i++;
                    // Incrementing i with +1

                    cmd.CommandType = CommandType.Text;
                    var query = "INSERT INTO " + tableName + " (" + exerciseTypeQuery + ", [ID], [UserName], " +
                                otherExercise1 + "," + otherExercise2 +
                                ") VALUES(@exerciseTypeQuery, @id, @username, @unusedExercise1, @unusedExercise2)";
                    // The ADO.NET command
                    cmd.CommandText = query;
                    // Assigning the command to the OleDbCommand
                    cmd.Parameters.AddWithValue("@exerciseTypeQuery", insertQuery);
                    // Putting the main pipe-separated data into the cells
                    cmd.Parameters.AddWithValue("@id", i.ToString());
                    cmd.Parameters.AddWithValue("@username", usernamestringo);
                    cmd.Parameters.AddWithValue("@unusedExercise1", empty); // these will be empty for now
                    cmd.Parameters.AddWithValue("@unusedExercise2", empty); // these will be empty for now

                    cmd.Connection = myCon;
                    // Declaring using a command that myCon is the connection
                    myCon.Open();
                    // Open the connection
                    cmd.ExecuteNonQuery();
                    // Executing the ADO.NET command
                    MessageBox.Show(@"Your record has been logged in!", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // Show success message!
                    cmd.Parameters.Clear();
                    // Clear the verbatim strings
                }

                #endregion
            }
            catch (OleDbException exception)
            {
                // Already explained above
                var errorMessages = "";
                for (var i = 0; i < exception.Errors.Count; i++)
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
            var cntPath = Directory.GetCurrentDirectory(); 
            // Get local directory in a string
            usernamestringo = Login.UsernameFromLogin;
            // Assign usernamestringo as the username value from the login form
            var tableName = usernamestringo + "_SESSIONS";
            // Call the table... already explained above

            var rawList = new List<string>();
            // Create a string list called rawList
            //int a;
            //int b;
            connection =
                new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" +
                                    usernamestringo.ToLower() + "_LOG.accdb;");
            // Declaring connection string and address
            Sql = "SELECT * FROM " + tableName;
            // ADO.NET command

            try
            {
                connection.Open();
                // Open the connection
                oledbAdapter = new OleDbDataAdapter(Sql, connection);
                // Declare the DataAdapter and tell it where to go and how
                var dsSet = new DataSet();
                // Declare dsSet as a new DataSet
                oledbAdapter.Fill(dsSet);
                // Data adapter fills the DataSet with the data
                rawList.AddRange(from DataRow row in dsSet.Tables[0].Rows select row["Running"].ToString());
                // Selects the "Running" column and copies it to rawList
                // Converted to LINQ-expression!
                // The bottom also works perfectly
                //
                //foreach (DataRow row in dsSet.Tables[0].Rows)
                //{
                //    rawList.Add(row["Running"].ToString());
                //}
                //


                
                var show = String.Join(null, rawList.ToArray());
                // convert List<string> to single string
                //label10.Text = show;

                //var showSplit = Regex.Split(show, " \\| ");
                // replaced by SplitIt
                var doubleVBarSplit = Regex.Split(show, " \\|\\| "); // splits separate sessions
                string dateSplit;
                string timeSplit;
                int duraSplit;
                string typeSplit;
                int calories;
                var totalCalories = 0;
                // Declaring variables
                /*
                 * Do bottom
                 */
                i = 1;
                // i is 1
                if (i < doubleVBarSplit.Length)
                // If the length of the double pipe string is greater than 1 then do:
                {
                    var session1 = doubleVBarSplit[1];
                    // The first split is assigned to a string called session1
                    var SplitIt1 = Regex.Split(session1, " \\| ");
                    // session1 is now split by one pipe |
                    dateSplit = DateTime.Parse(SplitIt1[0]).ToShortDateString();
                    // The first data after the split is the date, it will parse it as a string and store it in dateSplit
                    // .ToShortDateString means that it will not display the day.
                    // Instead of Monday, 21-03-87 it will display 21-03-87
                    timeSplit = string.Concat(SplitIt1[1]);
                    // The second data after the split is the time which is a string so it is concatenated
                    duraSplit = int.Parse(SplitIt1[2]);
                    // The third data after the split is the duration which is a string so it is parsed to an integer
                    typeSplit = string.Concat(SplitIt1[3]);
                    // The fourth data after the split is the type of the exercise which is a string so it's concatenated
                    RunningSession1.Visible = true;
                    // Show the training record
                    RunningCalories1.Visible = true;
                    // Show the calories burnt
                    RunningTotalCalories.Visible = true;
                    // Show total calories burnt
                    RunningSession1.Text = "Date: " + dateSplit + "\n " +
                                           "Time: " + timeSplit + "\n " +
                                           "Duration: " + duraSplit + "\n " +
                                           "Type: " + typeSplit + "\n \n ";
                    // The training record will be displayed in this format ^
                    


                    // If exercise type is "x" then calories will be xcalories * the duration
                    // The number of calories is then added to the total calories using +=
                    // TotalCalories is then converted to a string
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
                        calories = 885*duraSplit;
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
                    // If there aren't then that means there are no training logs found!
                    label11.Text = "There are no logs! \n Try again.";
                    foreach (var source in doubleVBarSplit.Skip(1))
                    // Skip this (well this is redundant)
                    {
                    }
                }


                /*
                 * Do bottom
                 */
                // The same thing again but this time it is the second session
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
                        calories = 472*duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "6 mph")
                    {
                        calories = 590*duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "7 mph")
                    {
                        calories = 679*duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "8 mph")
                    {
                        calories = 797*duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "9 mph")
                    {
                        calories = 885*duraSplit;
                        RunningCalories2.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "10 mph")
                    {
                        calories = 944*duraSplit;
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


                // The same thing again but this time it is the third session
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
                        calories = 472*duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "6 mph")
                    {
                        calories = 590*duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "7 mph")
                    {
                        calories = 679*duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "8 mph")
                    {
                        calories = 797*duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "9 mph")
                    {
                        calories = 885*duraSplit;
                        RunningCalories3.Text = @"You burnt " + calories + @" calories";
                        totalCalories += calories;
                        RunningTotalCalories.Text = totalCalories.ToString();
                    }
                    else if (typeSplit == "10 mph")
                    {
                        calories = 944*duraSplit;
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
            // If there is an error then...
            {
                MessageBox.Show(exception.ToString());
                // Print a messagebox showing the error
            }
            connection.Close();
            // Close the connection
            connection.Dispose();
            // Dispose of the connection in order to prevent exceptions later on in the program
        }

        /*
         * The above was for running, below is the same algorithm but for cycling. 
         * No difference.
         */


        private void CyclingView_Click(object sender, EventArgs e)
        {
            var cntPath = Directory.GetCurrentDirectory();
            usernamestringo = Login.UsernameFromLogin;
            var tableName = usernamestringo + "_SESSIONS";

            var rawList = new List<string>();
            connection =
                new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" +
                                    usernamestringo.ToLower() + "_LOG.accdb;");
            Sql = "SELECT * FROM " + tableName;

            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(Sql, connection);
                // BEFORE: oledbAdapter = new OleDbDataAdapter();
                // WAS GETTING ERROR: SelectCommand.Connection property has not been initialized.
                // I had to pass the connection object on the adapter.
                var dsSet = new DataSet();
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
                var totalCalories = 0;

                //Session 1
                int i;
                i = 1;
                if (i < doubleVBarSplit.Length)
                {
                    var session1 = doubleVBarSplit[1];
                    var SplitIt1 = Regex.Split(session1, " \\| ");
                    dateSplit = DateTime.Parse(SplitIt1[0]).ToShortDateString();
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

        /*
         * The above was for cycling, below is the same algorithm but for swimming. 
         * No difference.
         */

        private void BT_SwimmingView_Click(object sender, EventArgs e)
        {
            var cntPath = Directory.GetCurrentDirectory();
            usernamestringo = Login.UsernameFromLogin;
            var tableName = usernamestringo + "_SESSIONS";

            var rawList = new List<string>();
            connection =
                new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" +
                                    usernamestringo.ToLower() + "_LOG.accdb;");
            Sql = "SELECT * FROM " + tableName;

            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(Sql, connection);
                var dsSet = new DataSet();
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
                var totalCalories = 0;

                // Session 1
                int i;
                i = 1;
                if (i < doubleVBarSplit.Length)
                {
                    var session1 = doubleVBarSplit[1];
                    var SplitIt1 = Regex.Split(session1, " \\| ");
                    dateSplit = DateTime.Parse(SplitIt1[0]).ToShortDateString();
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
                    if (typeSplit == "Breaststroke")
                        // BUG: Breaststroke was spelled wrong.
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

        #region "Variable declarations"

        public string usernamestringo;
        // This is the string which will carry the username value from Login form
        private readonly string[] exerciseTypeRange = {"Cycling", "Running", "Swimming"};
        // Declaring the types of exercises available in the combobox
        private readonly string[] cyclingStyleRange =
        {
            "<10 mph, leisure cycling", "10 - 11.9 mph, gentle", "12 - 13.9 mph, moderate", "14 - 15.9 mph, vigorous",
            "16 - 20 mph, very fast", ">20 mph, racing"
        };

        private readonly string[] runningSpeedRange = {"5 mph", "6 mph", "7 mph", "8 mph", "9 mph", "10 mph"};

        private readonly string[] swimmingStyleRange =
        {
            "Freestyle, slow", "Freestyle, fast", "Backstroke",
            "Breaststroke", "Butterfly"
        };

        private void TB_ClientName_TextChanged(object sender, EventArgs e)
        {
            Regex input = new Regex(@"^[a-zA-Z\s]+$", RegexOptions.IgnoreCase);
            if (input.IsMatch(TB_ClientName.Text))
            {
            }
            else
            {
                MessageBox.Show("You can only enter letters or spaces!", "Error!", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
                TB_ClientHeight.Text = null;
                TB_ClientName.Text = null;
                TB_ClientWeight.Text = null;
                dateTimePicker1.ResetText();
            }
        }

        private void TB_ClientHeight_TextChanged(object sender, EventArgs e)
        {
            TB_ClientHeight.Text = string.Concat(TB_ClientHeight.Text.Where(char.IsNumber));
        }

        private void TB_ClientWeight_TextChanged(object sender, EventArgs e)
        {
            TB_ClientWeight.Text = string.Concat(TB_ClientWeight.Text.Where(char.IsNumber));
        }
        // Declaring the styles/speeds of exercises in the respective comboboxes

        #endregion
    }
}