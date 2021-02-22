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
    public partial class GUIMockup : Form
    {
        public GUIMockup()
        {
            InitializeComponent();
        }

        private void GUIMockup_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();

            ProgOps.CloseDatabaseDispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmOrders frmOrders = new frmOrders();
            frmOrders.Show();

        }
    }
}
