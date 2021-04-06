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
    public partial class frmMenu : Form
    {
        frmLogin LoggedIn;
        public int intSecurityLevel = 0;
        public int UserID = 0;
        public frmMenu(frmLogin Login)
        {
            InitializeComponent();
            LoggedIn = Login;
        }

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //maybe have ordersCust change text based on security level?
            //hide scheduke and incoming shipments if not employee
            if(intSecurityLevel < 2)
            {
                btnIncomOrders.Hide();
                btnSchedule.Hide();
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            //open frmProoduct or lookup or whatever
            frmLookup looking = new frmLookup(this);
            looking.Show();
        }

        private void btnOrdersCust_Click(object sender, EventArgs e)
        {
            //open orders for customers
            frmSales frmSales = new frmSales();
            frmSales.Show();
            this.Hide();
            //search orders for customers if employee

        }

        private void btnIncomOrders_Click(object sender, EventArgs e)
        {
            //check shipments coming in
            frmOrders orders = new frmOrders(this);
            orders.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //view schedules if employee
            frmSchedules schedules = new frmSchedules(this);
            schedules.Show();
            this.Hide();
            //manipulate if manager
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //return to frmLogin
            frmLogin LoggedIn = new frmLogin();
            LoggedIn.Show();
            this.Hide();
        }
    }
}
