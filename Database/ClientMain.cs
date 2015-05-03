﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Domain;
using Sessionator;
using ADOX;

namespace Database
{
    public partial class ClientMain : Form
    {
        #region "Variable declarations"
        public string usernamestringo;
        public string passwordstringo;
        private readonly string[] exerciseTypeRange = new[] {"Cycling", "Running", "Swimming"};

        private readonly string[] cyclingStyleRange = new[]
        {
            "<10 mph, leisure cycling", "10 - 11.9 mph, gentle", "12 - 13.9 mph, moderate", "14 - 15.9 mph, vigorous",
            "16 - 20 mph, very fast", ">20 mph, racing"
        };

        private readonly string[] runningSpeedRange = new[] {"5 mph", "6 mph", "7 mph", "8 mph", "9 mph", "10 mph"};

        private readonly string[] swimmingStyleRange = new[]
        {"Freestyle, slow", "Freestyle, fast", "Backstroke", "Breaststroke", "Butterfly"};
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
                    cmd.Parameters.AddWithValue("@Name", name.ToString());
                    cmd.Parameters.AddWithValue("@Height", heightint.ToString());
                    cmd.Parameters.AddWithValue("@Weight", weightint.ToString());
                    cmd.Parameters.AddWithValue("@Bday", bday.ToString());
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
                MessageBox.Show(errorMessages.ToString());
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
            SessiondateTimePicker.ResetText();
            hourComboBox.SelectedIndex = -1;
            minuteComboBox.SelectedIndex = -1;
            TB_Duration.Text = null;
            exerciseStyleComboBox.SelectedIndex = -1;
            exerciseTypeComboBox.SelectedIndex = -1;
        }

        private void BT_Log_Click(object sender, EventArgs e)
        {
            try
            {
                #region "Log tab args"
                #region "Declaring/testing variables

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

                MessageBox.Show("Date " + date + "\n" +
                                "Time: " + hourTime + ":" + minuteTime + "\n" +
                                "Duration: " + duration + "\n" +
                                "Exercise Type: " + exerciseType + "\n" +
                                "Exercise Style: " + exerciseStyle + "\n");
                #endregion

                string cntPath = System.IO.Directory.GetCurrentDirectory();
                using (OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" + usernamestringo.ToLower() + "_LOG.accdb;"))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    string query = "UPDATE " + tableName + " SET []";
                }
            }
            catch 
            {

            }

                #endregion
        }

        

        

    }
}
