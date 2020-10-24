using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vuttr.Domain.Entities.Ferramentas;

namespace Vuttr.Infra.Data.Mappings.Ferramentas
{
    public class FerramentaMap : IEntityTypeConfiguration<Ferramenta>
    {
        public void Configure(EntityTypeBuilder<Ferramenta> builder)
        {
            builder.ToTable("ferramentas");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("ferramenta_id");

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(240)")
                   .IsRequired();

            builder.Property(c => c.Link)
                   .HasColumnName("link")
                   .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.Property(c => c.Descricao)
                   .HasColumnName("descricao")
                   .HasColumnType("varchar(400)")
                   .IsRequired();
        }
    }
}
