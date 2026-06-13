using Golabgiri.App.Product;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Golabgiri.App
{
    public partial class mainform : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public mainform(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        public int i = 0;

        private void picproduct_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                var frm = _serviceProvider.GetRequiredService<frmProduct>();
                frm.ShowDialog();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if(RtlMessageBox.Show("آیا مطمئن هستید که میخواهید از برنامه خارج شوید","توجه",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            Application.Exit();
        }

        private void lblcustomer_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                var frm = _serviceProvider.GetRequiredService<frmCustomer>();
                frm.ShowDialog();
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
