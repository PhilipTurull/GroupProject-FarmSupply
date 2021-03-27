using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check for matching email to database

            //pull up products if customer
            frmMenu menu = new frmMenu(this);
            menu.Show();
            this.Hide();
            //pull up 
            
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            //make new data in db and bring up frmSignUp
            //frmSignup Sign = new frmSignup(this);
            //this.Hide();
            //Sign.show();
           //bring them to login

            //messagebox to tell them too login?
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
