using System;
using Vuttr.Domain.Core.Interfaces.Repositories.EFCore;

namespace Vuttr.Infra.Data.Repositories.EFCore
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public void Adicionar(T t)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T t)
        {
            throw new NotImplementedException();
        }
    }
}
