
namespace CarrinhoDeCompras.Domain.Entidades
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
    }
}