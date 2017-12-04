namespace LojaVirtual.Infra.Data.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LojaVirtual_V0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        NomeCategoria = c.String(nullable: false, maxLength: 15),
                        Descricao = c.String(maxLength: 400),
                        Imagem = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        IdProduto = c.Int(nullable: false, identity: true),
                        NomeProduto = c.String(nullable: false, maxLength: 400),
                        IdFornecedor = c.Int(nullable: false),
                        IdCategoria = c.Int(nullable: false),
                        QuantidadePorUnidade = c.String(nullable: false, maxLength: 400),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnidadeEmEstoque = c.Int(),
                        InidadeSobEncomenda = c.Int(),
                    })
                .PrimaryKey(t => t.IdProduto)
                .ForeignKey("dbo.Fornecedores", t => t.IdFornecedor)
                .ForeignKey("dbo.Categorias", t => t.IdCategoria)
                .Index(t => t.IdFornecedor)
                .Index(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        IdFornecedor = c.Int(nullable: false, identity: true),
                        NomeFornecedor = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.IdFornecedor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "IdCategoria", "dbo.Categorias");
            DropForeignKey("dbo.Produtos", "IdFornecedor", "dbo.Fornecedores");
            DropIndex("dbo.Produtos", new[] { "IdCategoria" });
            DropIndex("dbo.Produtos", new[] { "IdFornecedor" });
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Produtos");
            DropTable("dbo.Categorias");
        }
    }
}
