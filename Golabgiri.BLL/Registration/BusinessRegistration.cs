using AutoMapper;
using Glabgiri.DAL.UnitOfWork;
using Golabgiri.BLL.Mapper;
using Golabgiri.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.Registration
{
    public static class BusinessRegistration
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
            var targetAssembly = typeof(BusinessRegistration).Assembly;

            services.Scan(scan => scan
                .FromAssemblies(targetAssembly)
                .AddClasses(classes => classes.Where(t => t.Name.EndsWith("Service")))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(LoginService).Assembly);
        }
    }
}
