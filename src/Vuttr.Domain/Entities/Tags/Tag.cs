using System.Collections.Generic;
using Vuttr.Domain.Core.DomainObjects.Entities;
using Vuttr.Domain.Core.DomainObjects.Interfaces;
using Vuttr.Domain.Entities.FerramentasTags;

namespace Vuttr.Domain.Entities.Tags
{
    public class Tag : Entity, IAggregateRoot
    {
        public Tag(string nome)
        {
            Nome = nome;
        }

        protected Tag() { }

        public string Nome { get; private set; }

        //EF Core
        public virtual ICollection<FerramentaTag> FerramentasTags { get; set; }
    }
}
