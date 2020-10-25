using Microsoft.Extensions.DependencyInjection;
using Vuttr.Domain.Interfaces.Repositories.Dapper.Ferramentas;
using Vuttr.Domain.Interfaces.Repositories.Dapper.Tags;
using Vuttr.Infra.Data.Repositories.Dapper.Ferramentas;
using Vuttr.Infra.Data.Repositories.Dapper.Tags;

namespace Vuttr.Infra.CrossCutting.IoC
{
    public class RepositoryDapperContainerDI
    {
        public static void RepositoryInject(IServiceCollection services)
        {
            services.AddTransient<IFerramentaDapperRepository, FerramentaDapperRepository>();
            services.AddTransient<ITagDapperRepository, TagDapperRepository>();
        }
    }
}
