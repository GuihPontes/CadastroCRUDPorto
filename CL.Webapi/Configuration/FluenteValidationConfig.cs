using CL.Core.DTO.Cliente;
using CL.Manager.Validator;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CL.Webapi.Configuration
{
    public static class FluenteValidationConfig
    {
        public static void AddFuenteValidationConfiguration(this IServiceCollection services)
        {
            services.AddControllers().
                AddNewtonsoftJson(x=> x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
                
                .AddFluentValidation(x => {

                x.RegisterValidatorsFromAssemblyContaining<NovoClienteValidator>();
                x.RegisterValidatorsFromAssemblyContaining<AlteraClienteValidator>();
                x.RegisterValidatorsFromAssemblyContaining<EnderecoValidador>();
                



                });

        }
    }
}
