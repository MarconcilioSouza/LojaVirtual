
namespace CarrinhoDeCompras.Domain.Entidades
{ 
    public class DetalhesPedido
    {
        public DetalhesPedido()
        {
        }
        public int IdDetalhesPedido { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal Disconto { get; set; }
    }
}
