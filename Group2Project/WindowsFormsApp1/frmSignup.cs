using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmsRUs
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
            //login.show();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(tbxPassword.Text != tbxPasswordRenter.Text)
            {
                MessageBox.Show("Passwords must match!!!", "Password issue", MessageBoxButtons.OK);
            }
            //ProgOps.SignupCommand(this);

        }
    }
}
