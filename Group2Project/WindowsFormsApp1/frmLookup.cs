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
    public partial class frmLookup : Form
    {
        frmMenu formMenu;
        public frmLookup(frmMenu menu)
        {
            InitializeComponent();
            formMenu = menu;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(txtSearch.Text))
                {
                    this.dgvProducts.CurrentCell = row.Cells[0];

                    ProductClick();

                    return;
                }
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            //adds items to ongoing order
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //return to menu
            formMenu.Show();
            ProgOps.CloseDatabaseDispose();
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //pull up full order
        }

        private void frmLookup_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
            ProgOps.InitProductDatabaseCommand(dgvProducts, lblDesc, pbxProduct);

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductClick();
        }

        private void ProductClick()
        {
            int intRowIndex = dgvProducts.CurrentRow.Index;

            string SelectedItem = dgvProducts.CurrentRow.Cells[0].Value.ToString();

            ProgOps.SelectedProductChange(SelectedItem, lblDesc, pbxProduct);
        }
    }
}
