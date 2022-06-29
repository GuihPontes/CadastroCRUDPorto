using CL.Data.Repository;
using CL.Manager.Implemetation;
using CL.Manager.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CL.Webapi.Configuration
{
    public static class DependecyInjectionConfig
        
    {
        public static void AddDependecyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteManager, ClienteManager>();
         

        }
    }
}
