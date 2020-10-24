namespace Vuttr.Domain.Core.Interfaces.Repositories.EFCore
{
    public interface IBaseRepository<T> where T : class
    {
        void Adicionar(T t);

        void Atualizar(T t);
    }
}
