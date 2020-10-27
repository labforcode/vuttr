using System;

namespace Vuttr.Application.ViewModels.Tags
{
    public class TagViewModel
    {
        public Guid TagId { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
