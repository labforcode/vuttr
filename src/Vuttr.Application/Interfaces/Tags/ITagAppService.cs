using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vuttr.Application.ViewModels.Tags;

namespace Vuttr.Application.Interfaces.Tags
{
    public interface ITagAppService : IDisposable
    {
        void Adicionar(TagViewModel tag);

        void Atualizar(TagViewModel tag);

        Task<IEnumerable<TagViewModel>> SelecionarTodos();
    }
}
