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
    public partial class frmAddOrEditcustomer : Form
    {
        public frmAddOrEditcustomer()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
                requiredFieldValidator2.ControlToValidate = txtcompanyphne;
                requiredFieldValidator3.ControlToValidate = null;
            }
            lblcompanyphne.Visible = company;
            txtcompanny.Visible = company;
            txtcompanyphne.Visible = company;
            lblpersonfamily.Visible = person;
            txtname.Visible = person;
            txtfamily.Visible = person;

        }
        private void btnsabt_Click(object sender, EventArgs e)
        {

        }

        private void frmAddOrEditcustomer_Load(object sender, EventArgs e)
        {
            companyOrPerson(company, person);
        }
    }
}
