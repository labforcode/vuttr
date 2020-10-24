using System;
using Vuttr.Domain.Entities.Ferramentas;
using Vuttr.Domain.Entities.Tags;

namespace Vuttr.Domain.Entities.FerramentasTags
{
    public class FerramentaTag
    {
        public FerramentaTag(Guid ferramentaId, Guid tagId)
        {
            FerramentaId = ferramentaId;
            TagId = tagId;
        }

        public FerramentaTag() { }

        public Guid FerramentaId { get; set; }

        //EF Core
        public virtual Ferramenta Ferramenta { get; set; }

        public Guid TagId { get; set; }

        //EF Core
        public virtual Tag Tag { get; set; }
    }
}
