using Microsoft.Extensions.DependencyInjection;
using Vuttr.Domain.Interfaces.Repositories.EFCore.Ferramentas;
using Vuttr.Domain.Interfaces.Repositories.EFCore.Tags;
using Vuttr.Infra.Data.Repositories.EFCore.Ferramentas;
using Vuttr.Infra.Data.Repositories.EFCore.Tags;

namespace Vuttr.Infra.CrossCutting.IoC
{
    public class RepositoryEFCoreContainerDI
    {
        public static void RepositoryInject(IServiceCollection services)
        {
            services.AddTransient<IFerramentaRepository, FerramentaRepository>();
            services.AddTransient<ITagRepository, TagRepository>();
        }
    }
}
