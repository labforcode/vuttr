using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vuttr.Domain.Entities.Tags;

namespace Vuttr.Infra.Data.Mappings.Tags
{
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("tags");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("tag_id");

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(c => c.DataCadastro)
                   .HasColumnName("data_cadastro")
                   .IsRequired();
        }
    }
}
