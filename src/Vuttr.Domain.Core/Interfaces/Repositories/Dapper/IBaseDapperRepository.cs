using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vuttr.Domain.Core.Interfaces.Repositories.Dapper
{
    public interface IBaseDapperRepository<T> where T : class
    {
        Task<IEnumerable<T>> SelecionarTodos();
    }
}
