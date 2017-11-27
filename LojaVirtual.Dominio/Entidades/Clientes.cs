
namespace CarrinhoDeCompras.Domain.Entidades
{
    public partial class Clientes
    {
        public Clientes()
        {
        }

        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public int IdCidade { get; set; }
        public int IdPedido { get; set; }
        public int IdEndereco { get; set; }
    }
}