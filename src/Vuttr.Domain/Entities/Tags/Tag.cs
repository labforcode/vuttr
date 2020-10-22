using Vuttr.Domain.Core.DomainObjects.Entities;

namespace Vuttr.Domain.Entities.Tags
{
    public class Tag : Entity
    {
        public Tag(string nome)
        {
            Nome = nome;
        }

        public Tag() { }

        public string Nome { get; private set; }
    }
}
