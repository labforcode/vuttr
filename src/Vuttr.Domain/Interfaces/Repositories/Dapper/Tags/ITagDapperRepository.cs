using System.Threading.Tasks;
using Vuttr.Domain.Core.Interfaces.Repositories.Dapper;
using Vuttr.Domain.Entities.Tags;

namespace Vuttr.Domain.Interfaces.Repositories.Dapper.Tags
{
    public interface ITagDapperRepository : IBaseDapperRepository<Tag>
    {
    }
}
