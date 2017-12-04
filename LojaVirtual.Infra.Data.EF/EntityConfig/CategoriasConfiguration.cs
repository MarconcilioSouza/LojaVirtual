using LojaVirtual.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.Infra.Data.EF.EntityConfig
{
    public class CategoriasConfiguration : EntityTypeConfiguration<Categorias>
    {
        public CategoriasConfiguration()
        {
            ToTable("Categorias");

            HasKey(p => p.IdCategoria);
            Property(p => p.NomeCategoria).HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            Property(p => p.Descricao).HasColumnType("nvarchar").HasMaxLength(400).IsOptional();
            Property(p => p.Imagem).HasColumnType("image").IsOptional();

            HasMany(p => p.Produtos)
                .WithRequired(p => p.Categoria)
                .HasForeignKey(p => p.IdCategoria);
        }
    }
}
