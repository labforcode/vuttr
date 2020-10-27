using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vuttr.Application.Interfaces.Ferramentas;
using Vuttr.Application.ViewModels.Ferramentas;

namespace Vuttr.Application.Services.Ferramentas
{
    public class FerramentaAppService : IFerramentaAppService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ferramenta"></param>
        public void Adicionar(FerramentaViewModel ferramenta)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ferramenta"></param>
        public void Atualizar(FerramentaViewModel ferramenta)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ferramentaId"></param>
        public void Deletar(Guid ferramentaId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public Task<FerramentaViewModel> ObterFerramenta(string nome)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public Task<IEnumerable<FerramentaViewModel>> ObterFerramentas(string tag)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<FerramentaViewModel>> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
