using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using Vuttr.Application.AutoMapper;

namespace Vuttr.WebApi.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public static class AutoMapperSetup
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="services"></param>
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddAutoMapper(typeof(Startup));

            // Registering Mappings automatically only works if the
            // Automapper Profile classes are in ASP.NET project
            services.AddSingleton<IConfigurationProvider>(AutoMapperConfiguration.RegisterMappings());
        }
    }
}
