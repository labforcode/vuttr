using Microsoft.EntityFrameworkCore;
using Vuttr.Domain.Entities.Ferramentas;
using Vuttr.Domain.Entities.FerramentasTags;
using Vuttr.Domain.Entities.Tags;

namespace Vuttr.Infra.Data.Context
{
    public class VuttrContext : DbContext
    {
        #region DbSet

        public DbSet<Ferramenta> Ferramentas { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<FerramentaTag> FerramentasTags { get; set; }

        #endregion DbSet

        public VuttrContext(DbContextOptions<VuttrContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("public");
            builder.ApplyConfigurationsFromAssembly(typeof(VuttrContext).Assembly);
        }
    }
}
