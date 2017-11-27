using System;

namespace CarrinhoDeCompras.Domain.Entidades
{
    public partial class Pedidos 
    {
        public Pedidos()
        {
        }

        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime? DataEnvio { get; set; }
        public int IdEnderecoEntrega { get; set; }
        public decimal? ValorFrete { get; set; }
        public string StatusEnvio { get; set; }
    }
}