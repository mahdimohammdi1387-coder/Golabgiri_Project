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
        private void label3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                var frm = _serviceProvider.GetRequiredService<frmCustomer>();
                frm.ShowDialog();
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
