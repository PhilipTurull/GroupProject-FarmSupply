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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //maybe have ordersCust change text based on security level?
            //hide scheduke and incoming shipments if not employee
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            //open frmProoduct or lookup or whatever
        }

        private void btnOrdersCust_Click(object sender, EventArgs e)
        {
            //open orders for customers

            //search orders for customers if employee

        }

        private void btnIncomOrders_Click(object sender, EventArgs e)
        {
            //check shipments coming in
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //view schedules if employee

            //manipulate if manager
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //return to frmLogin
        }
    }
}
