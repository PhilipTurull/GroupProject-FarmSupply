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
    public partial class frmSchedules : Form
    {
        frmMenu formMenu;

        public frmSchedules(frmMenu menu)
        {
            InitializeComponent();

            formMenu = menu;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }

        private void frmSchedules_Load(object sender, EventArgs e)
        {
            //load in an employees schedule, we need to reformat so we can include dayss of the weeks
            ProgOps.Schedules(dgvSchedules, formMenu);
        }
    }
}
