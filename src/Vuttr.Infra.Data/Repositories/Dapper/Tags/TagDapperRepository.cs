using System.Collections.Generic;
using System.Threading.Tasks;
using Vuttr.Domain.Entities.Tags;
using Vuttr.Domain.Interfaces.Repositories.Dapper.Tags;

namespace Vuttr.Infra.Data.Repositories.Dapper.Tags
{
    public class TagDapperRepository : BaseDapperRepository, ITagDapperRepository
    {
        public Task<IEnumerable<Tag>> SelecionarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
