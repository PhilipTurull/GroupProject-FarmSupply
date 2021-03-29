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
    public partial class frmReset : Form
    {
        public frmReset()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ProgOps.PasswordReset(tbxCurrent, tbxNew, tbxReEnter, this);
        }
    }
}
