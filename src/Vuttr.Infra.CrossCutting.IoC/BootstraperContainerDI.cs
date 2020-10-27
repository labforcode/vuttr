using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Vuttr.Infra.CrossCutting.IoC
{
    public class BootstraperContainerDI
    {
        public static void Injector(IServiceCollection services, IConfiguration configuration)
        {
            ContextContainerDI.ContextInject(services, configuration);

            //InfraContainerDI.InfraRegister(services);

            //DomainBusContainerDI.DomainBusInject(services);

            //CommandsContainerDI.CommandsRegister(services);

            //EventsContainerDI.EventsRegister(services);

            RepositoryEFCoreContainerDI.RepositoryInject(services);

            RepositoryDapperContainerDI.RepositoryInject(services);

            AppServiceContainerDI.AppServiceInject(services);
        }
    }
}
