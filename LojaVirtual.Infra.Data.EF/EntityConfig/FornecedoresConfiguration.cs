using LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Infra.Data.EF.EntityConfig
{
    public class FornecedoresConfiguration : EntityTypeConfiguration<Fornecedores>
    {
        public FornecedoresConfiguration()
        {
            ToTable("Fornecedores");

            HasKey(p => p.IdFornecedor);
            Property(p => p.NomeFornecedor).HasColumnType("nvarchar").HasMaxLength(400).IsRequired();

            HasMany(p => p.Produtos)
                .WithRequired(p => p.Fornecedor)
                .HasForeignKey(p => p.IdFornecedor);
        }
    }
}
