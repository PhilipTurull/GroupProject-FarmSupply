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
            //constrict listboox to items that share text in name or description
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
    }
}
