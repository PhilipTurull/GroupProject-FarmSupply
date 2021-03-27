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
    public partial class frmOrders : Form
    {
        frmMenu frmMenu;

        public frmOrders(frmMenu menu)
        {
            InitializeComponent();

            frmMenu = menu;
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            //Prog ops select top from orders, then use search to find the order
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMenu.Show();
            this.Close();

        }
    }
}
