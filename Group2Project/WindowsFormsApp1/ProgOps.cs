using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=inew2330sp21;User Id=group2sp212330;password=2548258";
        //build a connection to database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);


        private static SqlCommand _sqlProductsCommand;
        //data adaptor
        private static SqlDataAdapter _daProducts = new SqlDataAdapter();
        //data table
        private static DataTable _dtProductsTable = new DataTable();

        //getters and setters from frmProducts


        //getters and setters
        public static DataTable DTProductsTable
        {
            get { return _dtProductsTable; }
            set { _dtProductsTable = value; }
        }


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

        public static void InitProductDatabaseCommand(DataGridView dgvProducts, Label Description, PictureBox picture)
        {
            //set command object to null
            _sqlProductsCommand = null;

            //reset data adaptor and datatable to new
            _daProducts = new SqlDataAdapter();
            _dtProductsTable = new DataTable();

            string strDGVCommand = "Select Name, Price, InStock from group2sp212330.Products";
            string strLBLCommand = "Select Description from group2sp212330.Products where UPC = 1456789123";
            string strPBXCommand = "Select group2sp212330.Products.ImageIndex , ProductImage from group2sp212330.Products, group2sp212330.ProdImages where UPC = 1456789123 and group2sp212330.Products.ImageIndex = group2sp212330.ProdImages.ImageIndex;";
            try
            {
                //est cmd obj
                //HERE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                _sqlProductsCommand = new SqlCommand(strDGVCommand, _cntDatabase);
                //establish data adaptor
                _daProducts.SelectCommand = _sqlProductsCommand;
                //fill data table
                _daProducts.Fill(_dtProductsTable);
                //bind dgv to data table
                dgvProducts.DataSource = _dtProductsTable;

                _sqlProductsCommand = new SqlCommand(strLBLCommand, _cntDatabase);
                //establish data adaptor
                _daProducts.SelectCommand = _sqlProductsCommand;
                //fill data table
                Description.Text = _daProducts.ToString();
                //bind dgv to data table

                _sqlProductsCommand = new SqlCommand(strPBXCommand, _cntDatabase);
                //establish data adaptor
                _daProducts.SelectCommand = _sqlProductsCommand;
                Images ProdImage = new Images();
                SqlDataReader sqlReader;

                try
                {
                    sqlReader = _sqlProductsCommand.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        
                        ProdImage.ImageID = sqlReader.GetInt32(0); // MS SQL Datatype int
                        ProdImage.Image = (byte[])sqlReader[1]; // MS SQL Datatype varbinary(MAX)
                        
                    }

                    using (MemoryStream ms = new MemoryStream(ProdImage.Image))
                    {
                        Image image = Image.FromStream(ms);
                        picture.Image = image;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error reloading images.", "Error with Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose of cmd, adaptor, and table 
            _sqlProductsCommand.Dispose();
            _daProducts.Dispose();
            _dtProductsTable.Dispose();
        }


    } 
    public class Images
        {
            public int ImageID { get; set; }
            public byte[] Image { get; set; }

            public Images()
            {
                //Default constructor
            }

            // Allow for two parameters (Coding preference)
            // Not used in this demonstration.
            public Images(int intNumber, byte[] imageArray)
            {
                ImageID = intNumber;
                Image = imageArray;
            }
        }
}
