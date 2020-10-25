using System;
using Vuttr.Domain.Entities.Ferramentas;
using Vuttr.Domain.Interfaces.Repositories.EFCore.Ferramentas;

namespace Vuttr.Infra.Data.Repositories.EFCore.Ferramentas
{
    public class FerramentaRepository : BaseRepository<Ferramenta>, IFerramentaRepository
    {
        public void Deletar(Guid ferramentaId)
        {
            throw new NotImplementedException();
        }
    }
}
