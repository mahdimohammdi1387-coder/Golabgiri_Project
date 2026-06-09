using AutoMapper;
using Golabgiri.App.Customer;
using Golabgiri.App.Mapper;
using Golabgiri.BLL.Mapper;
using Golabgiri.BLL.Registration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Golabgiri.App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoMapperConfig.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            services.AddBusinessLayer();

            services.AddTransient<frmLogin>();
            services.AddTransient<mainform>();
            services.AddTransient<frmAddOrEditcustomer>();
            services.AddTransient<frmselecttypecustomer>();
            services.AddTransient<frmCustomer>();

            var serviceProvider = services.BuildServiceProvider();


            var mainForm = serviceProvider.GetRequiredService<frmLogin>();
            Application.Run(mainForm);

        }
    }
}
