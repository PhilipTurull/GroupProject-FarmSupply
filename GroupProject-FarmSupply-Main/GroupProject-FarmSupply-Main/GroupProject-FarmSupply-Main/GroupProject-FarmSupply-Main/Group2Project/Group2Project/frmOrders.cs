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
            ProgOps.Products(dgvProducts);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMenu.Show();
            this.Close();

        }

        string UPC = "";

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvProducts.Rows[e.RowIndex];
            UPC = dgvRow.Cells[0].Value.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //ProgOps.Schedules(dgvSchedules, tbxEmployeeID);
            ProgOps.Restock(tbxQuantity, UPC);
        }
    }
}
