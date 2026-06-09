using Golabgiri.App.Properties;
using Golabgiri.BLL.Mapper;
using Golabgiri.BLL.Services;
using Golabgiri.App.Mapper;

using Golabgiri.ViewModel.DTO.LoginDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using AutoMapper;
using Golabgiri.BLL.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace Golabgiri.App
{
    public partial class frmLogin : Form
    {
        private readonly ILoginService _loginService;
        private readonly IServiceProvider _serviceprovider;
        public frmLogin(ILoginService loginService, IServiceProvider serviceprovider)
        {
            InitializeComponent();
            _loginService = loginService;
            _serviceprovider = serviceprovider;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {                    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                List<string> list = new List<string>();
                list.Add(txtUseName.Text);
                list.Add(txtPassword.Text);
                bool status = _loginService.GetUser(AutoMapperConfig.Mapper.Map<LoginDTO>(list));
                if(status)
                {
                    var frm=_serviceprovider.GetRequiredService<mainform>();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                   RtlMessageBox.Show("نام کاربری یا رمز عبور نادرست است", "توجه",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
        }
        private bool isPasswordVisible = true;
        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtPassword.IconRight = Resources.eye_96px;
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
                isPasswordVisible = false;
            }
            else
            {
                txtPassword.IconRight = Resources.invisible_96px;
                txtPassword.PasswordChar = '.';
                txtPassword.UseSystemPasswordChar = true;
                isPasswordVisible = true;
            }
        }
    }
}
