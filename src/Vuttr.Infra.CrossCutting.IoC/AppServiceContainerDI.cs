using Microsoft.Extensions.DependencyInjection;
using Vuttr.Application.Interfaces.Ferramentas;
using Vuttr.Application.Interfaces.Tags;
using Vuttr.Application.Services.Ferramentas;
using Vuttr.Application.Services.Tags;

namespace Vuttr.Infra.CrossCutting.IoC
{
    public class AppServiceContainerDI
    {
        public static void AppServiceInject(IServiceCollection services)
        {
            services.AddTransient<IFerramentaAppService, FerramentaAppService>();
            services.AddTransient<ITagAppService, TagAppService>();
        }
    }
}
