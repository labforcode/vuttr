using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vuttr.Application.Interfaces.Tags;
using Vuttr.Application.ViewModels.Tags;

namespace Vuttr.Application.Services.Tags
{
    public class TagAppService : ITagAppService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        public void Adicionar(TagViewModel tag)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        public void Atualizar(TagViewModel tag)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<TagViewModel>> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
