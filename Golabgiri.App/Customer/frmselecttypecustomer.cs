using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golabgiri.App.Customer
{
    public partial class frmselecttypecustomer : Form
    {
        public frmselecttypecustomer()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmAddOrEditcustomer frm = new frmAddOrEditcustomer();
        private void piccompany_Click(object sender, EventArgs e)
        {
           
            frm.company = true;
            frm.person=false;
            this.Close();
            frm.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.ShowDialog();
        }
    }
}
