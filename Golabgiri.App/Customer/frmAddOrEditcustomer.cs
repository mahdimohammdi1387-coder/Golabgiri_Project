using Golabgiri.BLL.IServices;
using Golabgiri.BLL.Services;
using Golabgiri.ViewModel.DTO.CustomerDTO;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Golabgiri.App.Customer
{
    public partial class frmAddOrEditcustomer : Form
    {
        private readonly ICustomerService _customerservice;
        private readonly IServiceProvider _serviceprovider;
        public frmAddOrEditcustomer(ICustomerService customerService , IServiceProvider serviceprovider)
        {
            InitializeComponent();
            _customerservice = customerService;
            _serviceprovider = serviceprovider;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool status=false;
        public bool company=false;
        public bool person = true;
        private void btnclose_MouseHover(object sender, EventArgs e)
        {
            ToolTip t=new ToolTip();
            t.SetToolTip(btnclose,"بازگشت");
        }
        public void companyOrPerson(bool company,bool person)
        {
            if(company==true)
            {
                requiredFieldValidator1.ControlToValidate = txtcompanny;
                requiredFieldValidator3.ControlToValidate = txtcompanyphne;
                requiredFieldValidator2.ControlToValidate = txtcompanyphne;
                requiredFieldValidator2.ErrorMessage = requiredFieldValidator3.ErrorMessage;
            }
            lblcompanyphne.Visible = company;
            txtcompanny.Visible = company;
            txtcompanyphne.Visible = company;
            lblpersonfamily.Visible = person;
            txtname.Visible = person;
            txtfamily.Visible = person;

        }
        public int ID = 0;
        private async void btnsabt_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                bool flag=false;
                CustomerDTO customerdto = new CustomerDTO();
                customerdto.name = txtname.Text;
                customerdto.family = txtfamily.Text;
                customerdto.address = txtAddress.Text;
                if (company == true)
                {
                    customerdto.phoneNumber = txtcompanyphne.Text;
                    customerdto.CustomerType = 2;
                }
                else
                {
                    customerdto.phoneNumber = txtphonenumber.Text;
                    customerdto.CustomerType = 1;
                }
               
                if (status==false)
                {
                    customerdto.credit = 0;
                    customerdto.debit = 0;
                    flag =await _customerservice.InsertCustomerAsync(customerdto);
                    await _customerservice.SaveAsync();
                }
                else
                {
                    customerdto.Id = ID;
                    flag= await _customerservice.UpdateCustomerAsync(customerdto);
                    await _customerservice.SaveAsync();
                }
                if (flag)
                {
                    
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("عملیات با شکست مواجه شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void frmAddOrEditcustomer_Load(object sender, EventArgs e)
        {
            companyOrPerson(company, person);
        }
    }
}
