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

        //Product Form Information
        private static SqlCommand _sqlProductsCommand;
        //data adaptor
        private static SqlDataAdapter _daProducts = new SqlDataAdapter();
        //data table
        private static DataTable _dtProductsTable = new DataTable();

        private static DataTable _dtProductDescriptionTable = new DataTable();


        //Swap image and description info
        private static SqlCommand _sqlProductCommand;
        //data adaptor
        private static SqlDataAdapter _daProduct = new SqlDataAdapter();
        //data table
        private static DataTable _dtProductTable = new DataTable();


        public static int SelectedUPC;

        //getters and setters
        public static DataTable DTProductsTable
        {
            get { return _dtProductsTable; }
            set { _dtProductsTable = value; }
        }


        public static DataTable DTProductTable
        {
            get { return _dtProductTable; }
            set { _dtProductTable = value; }
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

            _dtProductDescriptionTable = new DataTable();

            string sql = "Select top 1 * from group2sp212330.Products;";

            SqlCommand cmdInit = new SqlCommand();

            cmdInit = new SqlCommand(sql, _cntDatabase);
            SqlDataReader sqlReaderInit = cmdInit.ExecuteReader();

           
            int upc = 0;

            if (sqlReaderInit.Read())
            {
                
                var varUPC = sqlReaderInit["UPC"].ToString();

                int.TryParse(varUPC, out SelectedUPC);
            }
            sqlReaderInit.Close();


            string strDGVCommand = "Select Name, Price, InStock from group2sp212330.Products";
            string strLBLCommand = $"Select Description from group2sp212330.Products where UPC = {SelectedUPC}";
            string strPBXCommand = $"Select group2sp212330.Products.ImageIndex , ProductImage from group2sp212330.Products, group2sp212330.ProdImages where UPC = {SelectedUPC} and group2sp212330.Products.ImageIndex = group2sp212330.ProdImages.ImageIndex;";

            //set command object to null
            _sqlProductsCommand = null;
            //FILLS TABLE AND OBJECTS
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
                _daProducts.Fill(_dtProductDescriptionTable);
               
                Description.DataBindings.Add("Text", _dtProductDescriptionTable, "Description");
                

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
                    sqlReader.Close();
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

        public static void SelectedProductChange(string SelectedItemName, Label Description, PictureBox pbProductImage)
        {
            //
            _sqlProductCommand = null;
            _daProduct = new SqlDataAdapter();
            _dtProductTable = new DataTable();

            _dtProductDescriptionTable = new DataTable();

            try
            {
                //string to build the query
                string query = $"Select group2sp212330.ProdImages.ImageIndex, ProductImage, Description from group2sp212330.Products, group2sp212330.ProdImages where Name = '{SelectedItemName}' and group2sp212330.Products.ImageIndex = group2sp212330.ProdImages.ImageIndex;";
                //establish command object
                _sqlProductCommand = new SqlCommand(query, _cntDatabase);
                //establish data adapter
                _daProduct = new SqlDataAdapter();
                _daProduct.SelectCommand = _sqlProductCommand;
                //fill data table
                _dtProductTable = new DataTable();
                _daProduct.Fill(_dtProductTable);
                //bind controls to the textboxes

                DataRow DataRow = _dtProductTable.Rows[0];

                Description.Text = DataRow["Description"].ToString();

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
                        pbProductImage.Image = image;
                    }
                    sqlReader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error reloading images.", "Error with Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in establishing New Image. Error 301.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            //dispose of cmd, adaptor, and table 
            _sqlProductCommand.Dispose();
            _daProduct.Dispose();
            _dtProductTable.Dispose();
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

    //ProgOps.SignupCommand(frmSignup Signup)
    //{
            //string cmdSignup = $"Insert into group2sp212330.Customers  (Name, Password, Address, Email, Phone) Values {}"
    //}
}
