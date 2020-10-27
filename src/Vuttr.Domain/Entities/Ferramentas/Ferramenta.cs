using System;
using System.Collections.Generic;
using Vuttr.Domain.Core.DomainObjects.Entities;
using Vuttr.Domain.Core.DomainObjects.Interfaces;
using Vuttr.Domain.Entities.FerramentasTags;

namespace Vuttr.Domain.Entities.Ferramentas
{
    public class Ferramenta : Entity, IAggregateRoot
    {
        public Ferramenta(string nome, string link, string descricao, DateTime dataCadastro)
        {
            Nome = nome;
            Link = link;
            Descricao = descricao;
            DataCadastro = dataCadastro;
        }

        protected Ferramenta() { }

        public string Nome { get; private set; }

        public string Link { get; private set; }

        public string Descricao { get; private set; }

        public DateTime DataCadastro { get; private set; }

        //EF Core
        public virtual ICollection<FerramentaTag> FerramentaTags { get; set; }
    }
}
