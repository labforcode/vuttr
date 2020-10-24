using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vuttr.Domain.Entities.FerramentasTags;

namespace Vuttr.Infra.Data.Mappings.FerramentasTags
{
    public class FerramentaTagMap : IEntityTypeConfiguration<FerramentaTag>
    {
        public void Configure(EntityTypeBuilder<FerramentaTag> builder)
        {
            builder.ToTable("ferramentas_tags");
            builder.HasKey(c => new { c.FerramentaId, c.TagId });

            builder.Property(c => c.FerramentaId)
                   .HasColumnName("ferramenta_id");

            builder.Property(c => c.TagId)
                   .HasColumnName("tag_id");
        }
    }
}
