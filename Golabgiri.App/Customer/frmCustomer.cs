using Golabgiri.App.Mapper;
using Golabgiri.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Golabgiri.ViewModel.DTO.CustomerDTO;
using Golabgiri.Utility.Seperators;
using Golabgiri.App.Customer;
using Golabgiri.BLL.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace Golabgiri.App
{
    public partial class frmCustomer : Form
    {
        ICustomerService _customerService;
        IServiceProvider _serviceProvider;
        public frmCustomer(ICustomerService customerService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _customerService = customerService;
            _serviceProvider = serviceProvider;
        }
        async void Customer_Load()
        {
            dgvCustomer.Rows.Clear();
            var customer = await _customerService.GetAllCustomerAsync();
            foreach (var item in customer)
            {
                string debit = PointSeprator.RemoveTrailingZeros(item.debit);
                string credit = PointSeprator.RemoveTrailingZeros(item.credit);
                dgvCustomer.Rows.Add(item.Id, item.name +" "+ item.family, item.phoneNumber, SepCama.Cama(credit),
                   item.address, SepCama.Cama(debit),"ریال",item.CustomerType);
            }
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
           Customer_Load();
            var frm=_serviceProvider.GetRequiredService<mainform>();
            frm.i = 0;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnewPerson_Click(object sender, EventArgs e)
        {
            frmselecttypecustomer frm=new frmselecttypecustomer();
            frm.ShowDialog();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dgvCustomer.CurrentRow!=null)
            {
                int id = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                var customer=await _customerService.GetCustomerByIdAsync(id);
                frmAddOrEditcustomer frm=new frmAddOrEditcustomer();
                frm.lblsubject.Text = "ویرایش طرف حساب";
                if (customer.CustomerType==1)
                {

                    frm.txtname.Text = customer.name;
                    frm.txtfamily.Text = customer.family;
                    frm.txtphonenumber.Text = customer.phoneNumber;
                }
                else
                {
                    frm.company = true;
                    frm.person = false;
                    frm.txtcompanny.Text = customer.name;
                    frm.txtcompanyphne.Text = customer.phoneNumber;
                }
                   
                frm.txtAddress.Text = customer.address;
                frm.ShowDialog();
            }
            else
                RtlMessageBox.Show("ابتدا یک طرف حساب را مشخص کنید","توجه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
