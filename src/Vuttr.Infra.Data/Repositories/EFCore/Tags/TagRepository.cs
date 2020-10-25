using Vuttr.Domain.Entities.Tags;
using Vuttr.Domain.Interfaces.Repositories.EFCore.Tags;

namespace Vuttr.Infra.Data.Repositories.EFCore.Tags
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
    }
}
