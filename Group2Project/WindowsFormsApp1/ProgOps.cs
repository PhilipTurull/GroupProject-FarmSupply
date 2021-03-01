using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=inew2330sp21;User Id=group2sp212330;password=2548258";
        //build a connection to database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);

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

    }
}
