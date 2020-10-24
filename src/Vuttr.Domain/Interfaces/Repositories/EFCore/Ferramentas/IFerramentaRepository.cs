using System;
using Vuttr.Domain.Core.Interfaces.Repositories.EFCore;
using Vuttr.Domain.Entities.Ferramentas;

namespace Vuttr.Domain.Interfaces.Repositories.EFCore.Ferramentas
{
    public interface IFerramentaRepository : IBaseRepository<Ferramenta>
    {
        void Deletar(Guid ferramentaId);
    }
}
