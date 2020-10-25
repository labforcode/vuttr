using System.Collections.Generic;
using System.Threading.Tasks;
using Vuttr.Domain.Entities.Ferramentas;
using Vuttr.Domain.Interfaces.Repositories.Dapper.Ferramentas;

namespace Vuttr.Infra.Data.Repositories.Dapper.Ferramentas
{
    public class FerramentaDapperRepository : BaseDapperRepository, IFerramentaDapperRepository
    {
        public Task<Ferramenta> ObterFerramenta(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Ferramenta>> ObterFerramentas(string tag)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Ferramenta>> SelecionarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
