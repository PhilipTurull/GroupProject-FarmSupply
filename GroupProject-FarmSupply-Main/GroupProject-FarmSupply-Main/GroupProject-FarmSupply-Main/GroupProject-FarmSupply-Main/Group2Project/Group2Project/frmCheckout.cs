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
    public partial class frmCheckout : Form
    {
        frmLookup looking;
        public frmCheckout(frmLookup look)
        {
            looking = look;
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxCart.Items.Count == 0)
            {
                MessageBox.Show("Sorry, it looks like you don't have any items in your cart! Add some goodies and feel free to come check out here!");
                return;
            }
            if (!lbxCart.Focus())
            {
                lbxCart.SelectedIndex = 0;
            }
            if (lbxCart.Items.Count > 0)
            {
                for (int i = 0; i < looking.strCart.Count; i++)
                {
                    looking.strCart.Remove(lbxCart.SelectedItem.ToString());
                }

                looking.strDupe.Clear();

                looking.intProdCount.Clear();

                lbxCart.Items.RemoveAt(lbxCart.SelectedIndex);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            if (lbxCart.Items.Count == 0)
            {
                MessageBox.Show("Sorry, it looks like you don't have any items in your cart! Add some goodies and feel free to come check out here!");
                return;
            }
            List<string> Prodname = new List<string>();
            List<int> Quantities = new List<int>();
            List<double> ProdPrice = new List<double>();
            int intQuantity = 0;
            double dblPrice = 0;
            double totalPrice = 0;


            for (int i = 0; i < lbxCart.Items.Count; i++)
            {
                string placeholder = lbxCart.Items[i].ToString();

                string ProdName = placeholder.Substring(placeholder.IndexOf(" ") + 1, placeholder.Length - ((placeholder.Length - placeholder.IndexOf("$")) + 2));

                string ProdQuantity = placeholder.Substring(0, placeholder.IndexOf(" "));

                string strProdPrice = placeholder.Substring(placeholder.LastIndexOf("$") + 1, placeholder.Length - (placeholder.LastIndexOf("$") + 1));

                Prodname.Add(ProdName);
                int.TryParse(ProdQuantity, out intQuantity);
                Quantities.Add(intQuantity);
                double.TryParse(strProdPrice, out dblPrice);
                ProdPrice.Add(dblPrice);
            }

            for (int i = 0; i < ProdPrice.Count; i++)
            {
                totalPrice += ProdPrice[i];
            }

            for (int i = 0; i < Prodname.Count; i++)
            {
                Prodname[i].Replace("'", "''");
            }

            ProgOps.DatabaseCommandMakeOrder(Prodname, Quantities,ProdPrice, totalPrice, looking.formMenu.UserID);

            if (looking.strCart.Count() > 0)
            {
                looking.strCart.Clear();
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
