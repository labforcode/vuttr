using System.Collections.Generic;
using System.Threading.Tasks;
using Vuttr.Domain.Core.Interfaces.Repositories.Dapper;
using Vuttr.Domain.Entities.Ferramentas;

namespace Vuttr.Domain.Interfaces.Repositories.Dapper.Ferramentas
{
    public interface IFerramentaDapperRepository : IBaseDapperRepository<Ferramenta>
    {
        Task<Ferramenta> ObterFerramenta(string nome);

        Task<IEnumerable<Ferramenta>> ObterFerramentas(string tag);
    }
}
