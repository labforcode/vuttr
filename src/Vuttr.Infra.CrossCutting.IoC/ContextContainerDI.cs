using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vuttr.Infra.Data.Context;

namespace Vuttr.Infra.CrossCutting.IoC
{
    public class ContextContainerDI
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void ContextInject(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VuttrContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("dbvuttr")));
            services.AddScoped<VuttrContext, VuttrContext>();
        }
    }
}
