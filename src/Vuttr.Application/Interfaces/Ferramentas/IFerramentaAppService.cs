using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vuttr.Application.ViewModels.Ferramentas;

namespace Vuttr.Application.Interfaces.Ferramentas
{
    public interface IFerramentaAppService : IDisposable
    {
        void Adicionar(FerramentaViewModel ferramenta);

        void Atualizar(FerramentaViewModel ferramenta);

        void Deletar(Guid ferramentaId);

        Task<FerramentaViewModel> ObterFerramenta(string nome);

        Task<IEnumerable<FerramentaViewModel>> ObterFerramentas(string tag);

        Task<IEnumerable<FerramentaViewModel>> SelecionarTodos();
    }
}
