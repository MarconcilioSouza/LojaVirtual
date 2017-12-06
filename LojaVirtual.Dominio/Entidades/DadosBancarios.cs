using LojaVirtual.Dominio.Enum;
using System;

namespace LojaVirtual.Dominio.Entidades
{
    public class DadosBancarios
    {
        public DateTime DataDeCadastro { get; protected set; }
        public  InstituicaoFinanceira InstituicaoFinanceira { get; set; }
        public string NomedoBanco { get; set; }
        public string Agencia { get; protected set; }
        public string ContaCorrente { get; protected set; }
        public string Digito { get; protected set; }
        public string DadosHash { get; protected set; }
        public DateTime? DataProximaTentativa { get; protected set; }
        public bool? Invalido { get; protected set; }
        public DateTime? DataInvalido { get; protected set; }
        public StatusAutorizacaoBanco StatusAutorizacaoBanco { get; protected set; }
        public DateTime? DataEnviadoAutorizacao { get; set; }
    }
}
