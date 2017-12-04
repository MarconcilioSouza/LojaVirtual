using LojaVirtual.Dominio.Entidades;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LojaVirtual.Infra.Data.EF.EntityConfig;

namespace LojaVirtual.Infra.Data.EF.Common
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext() :
            base("LojaVirtual")
        {
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "ID").Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            modelBuilder.Properties<DateTime>().Configure(p => p.HasColumnType("datetime"));

            modelBuilder.Configurations.Add(new CategoriasConfiguration());
            modelBuilder.Configurations.Add(new ProdutosConfiguration());
            modelBuilder.Configurations.Add(new FornecedoresConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
