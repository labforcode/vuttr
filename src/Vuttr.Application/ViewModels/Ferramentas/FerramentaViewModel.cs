using System;

namespace Vuttr.Application.ViewModels.Ferramentas
{
    public class FerramentaViewModel
    {
        public Guid FerramentaId { get; set; }

        public string Nome { get; set; }

        public string Link { get; set; }

        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
