using LojaVirtual.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.Infra.Data.EF.EntityConfig
{
    public class ProdutosConfiguration : EntityTypeConfiguration<Produtos>
    {
        public ProdutosConfiguration()
        {
            ToTable("Produtos");

            HasKey(p => p.IdProduto);
            Property(p => p.NomeProduto).HasColumnType("nvarchar").HasMaxLength(400).IsRequired();
            Property(p => p.IdCategoria).IsRequired();
            Property(p => p.IdFornecedor).IsRequired();
            Property(p => p.QuantidadePorUnidade).HasColumnType("nvarchar").HasMaxLength(400).IsRequired();
            Property(p => p.ValorUnitario).IsRequired();
        }
    }
}
