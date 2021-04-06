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
    public partial class frmLookup : Form
    {
        public frmMenu formMenu;

        public List<string> strCart = new List<string>();
        public List<double> dblPrice = new List<double>();
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
            string strPrice;
            double dblCost;

            strCart.Add(dgvProducts.CurrentRow.Cells[0].Value.ToString());

            strPrice = dgvProducts.CurrentRow.Cells[1].Value.ToString();

            double.TryParse(strPrice, out dblCost);

            dblPrice.Add(dblCost);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //return to menu
            formMenu.Show();
            ProgOps.CloseDatabase();
            this.Close();
        }

        public List<int> intProdCount = new List<int>();
        public List<string> strDupe = new List<string>();
        public List<double> dblProdPrice = new List<double>();
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (strCart.Count == 0)
            {
                MessageBox.Show("Sorry, it looks like you don't have any items in your cart! Add some goodies and feel free to come check out here!");
                return;
            }

            frmCheckout checkout = new frmCheckout(this);
            int Count = 0;

            for (int i = 0; i < strCart.Count; i++)
            {
                //BIG ISSUE HERE THIS NEEDS TO BE ADJUSTED I JUST DON'T KNOW HOW
                if (strDupe.Contains(strCart[i]))
                {
                    intProdCount[strDupe.IndexOf(strCart[i])]++;
                    dblProdPrice[strDupe.IndexOf(strCart[i])] += dblPrice[strDupe.IndexOf(strCart[i])];
                }
                if (!strDupe.Contains(strCart[i]))
                {
                    intProdCount.Add(Count + 1);
                    strDupe.Add(strCart[i]);
                    dblProdPrice.Add(dblPrice[i]);
                }

            }

            for (int i = 0; i < strDupe.Count(); i++)
            {
                checkout.lbxCart.Items.Add(intProdCount[i].ToString() + " " + strDupe[i] + " $" + dblProdPrice[i].ToString("0.##"));
                MessageBox.Show(checkout.lbxCart.Items[i].ToString());
            }

            checkout.Show();
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
