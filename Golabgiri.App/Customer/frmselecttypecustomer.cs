using Golabgiri.BLL.IServices;
using Golabgiri.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
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
        ICustomerService _customerService;
        IServiceProvider _serviceProvider;
        public frmselecttypecustomer(ICustomerService customerService,IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerService = customerService;
            _serviceProvider = serviceProvider;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void piccompany_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<frmAddOrEditcustomer>();
            frm.company = true;
            frm.person=false;
            if(frm.ShowDialog()==DialogResult.OK)
                DialogResult = DialogResult.OK;
        }

        private void picPerson_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<frmAddOrEditcustomer>();
            if (frm.ShowDialog() == DialogResult.OK)
                DialogResult = DialogResult.OK;
        }
    }
}
