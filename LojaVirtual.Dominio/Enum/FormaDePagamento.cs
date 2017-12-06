using System.ComponentModel;

namespace LojaVirtual.Dominio.Enum
{
    public enum FormaDePagamento
    {
        [Description("Débito Automático")]
        DebitoAutomatico = 1,
        [Description("Boleto")]
        Boleto = 2,
        [Description("Cartão de Crédito")]
        CartaoCredito = 3,
        [Description("Vale Compra")]
        SaldoTag = 4,
    }
}
