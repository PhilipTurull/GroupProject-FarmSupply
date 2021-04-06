using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2Project
{
    public partial class frmSignup : Form
    {
        //frmLogin login;
       //frmLogin Login
        public frmSignup()
        {
            InitializeComponent();
            //login = Login;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            //sees if passwords are the same
            if (tbxPassword.Text == tbxPasswordRenter.Text)
            {
                ProgOps.SignupCommand(tbxEmailInput, tbxPassword, tbxPasswordRenter, tbxTitle, tbxFirstName, tbxLastName, tbxAddress, tbxPhone);
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Error");
            }

            //if(tbxPassword.Text != tbxPasswordRenter.Text)
            //{
            //    MessageBox.Show("Passwords must match!!!", "Password issue", MessageBoxButtons.OK);
            //}
            //ProgOps.SignupCommand(this);

        }
    }
}
