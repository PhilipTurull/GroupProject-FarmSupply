using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

//this prog ops keeps the connection to the database open throughout the whole application
//upon application closing it closes and disposes of the connection


namespace WindowsFormsApp1
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=inew2330sp21;User Id=group2sp212330;password=2548258";
        //build a connection to database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //add the data adapter
        private static SqlDataAdapter _daResults = new SqlDataAdapter();
        //add the data table
        private static DataTable _dtResultsTable = new DataTable();

        public static void OpenDatabase()
        {
            //method to open database

            //open the connection to books database
            _cntDatabase.Open();
            //message stating that connection to database was succesful
            MessageBox.Show("Connection to database was successfully opened.", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void CloseDatabaseDispose()
        {
            //method to close database and dispose of the connection object

            //close connection
            _cntDatabase.Close();
            //message stating that connection to database was succesful
            MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dispose of the connection object and command, adapter and table objects
            _cntDatabase.Dispose();

        }

        public static void Login(TextBox tbxUsername, TextBox tbxPassword)
        {
            //strings commands for CustomerID and EmployeeID 
            string sqlquery = "SELECT CustomerID,Password FROM group2sp212330.Customers WHERE CustomerID =@CustomerID";
            string sqlquery2 = "SELECT EmployeeID" /*+",Password"*/ +" FROM group2sp212330.Employees WHERE EmployeeID=@EmployeeID";

            //command query for customers to execute
            SqlCommand cmd = new SqlCommand(sqlquery, _cntDatabase);
            cmd.Parameters.AddWithValue("@CustomerID", tbxUsername.Text);
            SqlDataReader rd = cmd.ExecuteReader();

            //if customerid is found
            if (rd.Read())
            {
                //sets strings for returned values
                string CustomerID = rd.GetValue(0).ToString();
                string CustomerPassword = rd.GetValue(1).ToString();

                //if returned customerid is same as one entered
                if (CustomerID == tbxUsername.Text)
                {
                    //checks if password is same as one entered
                    if (CustomerPassword == tbxPassword.Text)
                    {
                        //opens up next form and closes reader
                        frmSchedules frmSchedules = new frmSchedules();
                        frmSchedules.ShowDialog();
                        rd.Close();
                    }

                    //if password is not same error pops up and reader closes
                    else
                    {
                        MessageBox.Show("Password is Incorrect.", "Error");
                        rd.Close();
                    }
                }
            }
            //if customerid is not found tries for emplpoyeeid 
            else
            {
                rd.Close();

                //command query for Employees to execute
                SqlCommand cmd2 = new SqlCommand(sqlquery2, _cntDatabase);
                cmd2.Parameters.AddWithValue("@EmployeeID", tbxUsername.Text);
                SqlDataReader rd2 = cmd2.ExecuteReader();

                //if Employeeid is found
                if (rd2.Read())
                {
                    //sets strings for returned values
                    string EmployeeID = rd2.GetValue(0).ToString();
                    //string EmployeePassword = rd2.GetValue(1).ToString();

                    //if returned Employeeid is same as one entered
                    if (EmployeeID == tbxUsername.Text)
                    {
                        //checks if password is same as one entered
                        //if (EmployeePassword == tbxPassword.Text)
                        //{
                            //opens up next form and closes reader
                            frmSchedules frmSchedules = new frmSchedules();
                            frmSchedules.ShowDialog();
                            rd2.Close();
                        //}

                        //if password is not same error pops up and reader closes
                        //else
                        //{
                            //MessageBox.Show("Password not in database", "Error");
                            //rd2.Close();
                        //}
                    }

                }
                else
                {
                    MessageBox.Show("Username is Incorrect.", "Error");
                    rd2.Close();
                }
            }
        }

        public static void PasswordRecovery(TextBox tbxCustomerID)
        {
            //string query to get the email and password based on entered customerid
            String sqlquery = "SELECT Email,Password FROM group2sp212330.Customers WHERE CustomerID =@CustomerID";

            //executes query
            SqlCommand cmd = new SqlCommand(sqlquery, _cntDatabase);
            cmd.Parameters.AddWithValue("@CustomerID", tbxCustomerID.Text);
            SqlDataReader rd = cmd.ExecuteReader();

            //strings for email message
            string msg = "Your current password is ";
            string username = "group2sp212330@gmail.com";

            //sees if username is in database
            if (rd.Read())
            {
                //adds password to email message
                msg = msg + rd.GetValue(1).ToString();
                username = rd.GetValue(0).ToString();

                //sets up sender and recipient
                MailMessage message = new MailMessage("group2sp212330@gmail.com", username);

                //email message
                message.Subject = "Test Email";
                message.Body = msg;

                //client setup
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                NetworkCredential credential = new NetworkCredential("group2sp212330@gmail.com", "g22548258");
                client.Credentials = credential;
                client.EnableSsl = true;
                client.Send(message);

                //message displaying that email has been sent
                MessageBox.Show("Email has been sent to the email associated with username.", "Email sent");
                rd.Close();
            }
            else
            {
                MessageBox.Show("Username is Incorrect.");
                rd.Close();
            }
        }

        public static void PasswordReset(TextBox tbxCurrent, TextBox tbxNew, TextBox tbxConfirm)
        {
            //sets up string for old password
            String Old = "abc";

            //string query to see if current password matches
            String sqlquery = "SELECT Password FROM group2sp212330.Customers WHERE Password=@Password";

            //executes query
            SqlCommand cmd = new SqlCommand(sqlquery, _cntDatabase);
            cmd.Parameters.AddWithValue("@Password", tbxCurrent.Text);
            SqlDataReader rd = cmd.ExecuteReader();

            //sees if current passwords matches
            if (rd.Read())
            {
                //current password is set to old string
                Old = rd.GetValue(0).ToString();
                rd.Close();

                // confirms new password is one the user wants
                if (tbxNew.Text == tbxConfirm.Text)
                {
                    //string query to update old password to new one
                    String sqlquery2 = "UPDATE group2sp212330.Customers SET Password = @New WHERE Password = @Old";

                    //executes querry
                    SqlCommand cmd2 = new SqlCommand(sqlquery2, _cntDatabase);
                    cmd2.Parameters.AddWithValue("@Old", Old);
                    cmd2.Parameters.AddWithValue("@New", tbxNew.Text);
                    rd = cmd2.ExecuteReader();
                    rd.Close();

                    //string querry to see if password reset is succesful
                    String sqlquery3 = "SELECT Password FROM group2sp212330.Customers WHERE Password=@Password";

                    //executes querry
                    SqlCommand cmd3 = new SqlCommand(sqlquery, _cntDatabase);
                    cmd3.Parameters.AddWithValue("@Password", tbxNew.Text);
                    rd = cmd3.ExecuteReader();

                    //message if succesful
                    if (rd.Read())
                    {
                        MessageBox.Show("Password has been reset.");
                    }
                    //message if failed
                    else
                    {
                        MessageBox.Show("Error Password has not been reset.");
                        rd.Close();
                    }


                }
                else
                {
                    MessageBox.Show("New Passwords do not match.");
                }
            }
            else
            {
                MessageBox.Show("Current Password is incorrect");
                rd.Close();
            }
        }

        public static void Schedules(DataGridView dgvSchedules, TextBox tbxEmployeeID)
        {
            //reset data adapter and datable to new
            _daResults = new SqlDataAdapter();
            _dtResultsTable = new DataTable();
            //est cmd obj
            try
            {
                String sqlSchedulesCommand = "Select * From group2sp212330.Employees WHERE EmployeeID=@EmployeeID";
                SqlCommand _sqlSchedulesCommand = new SqlCommand(sqlSchedulesCommand, _cntDatabase);
                _sqlSchedulesCommand.Parameters.AddWithValue("@EmployeeID", tbxEmployeeID.Text);
                //est data adapter
                _daResults.SelectCommand = _sqlSchedulesCommand;
                //fill data table
                _daResults.Fill(_dtResultsTable);
                //bind dgv to data table
                dgvSchedules.DataSource = _dtResultsTable;
                //dispose of cmd adapter, and table obj
                _sqlSchedulesCommand.Dispose();
                _daResults.Dispose();
                _dtResultsTable.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "EmployeeID not in database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
