using System;
using System.Collections.Generic;
using Vuttr.Domain.Core.DomainObjects.Entities;
using Vuttr.Domain.Core.DomainObjects.Interfaces;
using Vuttr.Domain.Entities.FerramentasTags;

namespace Vuttr.Domain.Entities.Tags
{
    public class Tag : Entity, IAggregateRoot
    {
        public Tag(string nome, DateTime dataCadastro)
        {
            Nome = nome;
            DataCadastro = dataCadastro;
        }

        protected Tag() { }

        public string Nome { get; private set; }

        public DateTime DataCadastro { get; private set; }

        //EF Core
        public virtual ICollection<FerramentaTag> FerramentasTags { get; set; }
    }
}
