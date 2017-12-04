namespace LojaVirtual.Dominio.Entidades
{
    public partial class Produtos
    {
        public Produtos()
        {
        }

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int IdFornecedor { get; set; }
        public int IdCategoria { get; set; }
        public string QuantidadePorUnidade { get; set; }
        public decimal? ValorUnitario { get; set; }
        public int? UnidadeEmEstoque { get; set; }
        public int? InidadeSobEncomenda { get; set; }

        public virtual Categorias Categoria { get; set; }
        public virtual Fornecedores Fornecedor { get; set; }
    }
}