using LojaVirtual.Dominio.Enum;
using System;
using System.Collections.Generic;

namespace LojaVirtual.Dominio.Entidades
{
    public partial class Clientes
    {
        public Clientes()
        {
        }

        #region Propriedades

        public int IdCliente { get; set; }
        public string Email { get; set; }
        public int IdPedido { get; set; }
        public DateTime DataCadastro { get; set; }
        public long Documento { get; set; }
        public string Rg { get; set; }
        public string NomeCliente { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto
        {
            get { return NomeCliente + " " + Sobrenome; }
        }
        public Endereco Endereco { get; set; }
        public DateTime? DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string DddCelular { get; set; }
        public string Celular { get; set; }
        public string DddTelefone { get; set; }
        public string Telefone { get; set; }
        public string NomeMae { get; set; }
        public bool AcessoOperacional { get; protected set; }
        public string Contato { get; set; }
        public long? CodigoERP { get; protected set; }
        public DateTime? DataCadastroERP { get; protected set; }
        public bool EmailsPromocionais { get; set; }
        public bool PrimeiroAcesso { get; protected set; }
        public DateTime? DataPrimeiroAcesso { get; protected set; }
       // public EnumInfo<StatusCliente> Status { get; set; }
        public DateTime? DataUltimaCobrancaPacoteSMS { get; set; }
        public bool PessoaFisica { get; protected set; }
        public DadosBancarios DadosBancarios { get; set; }
       // public DadosCartaoCredito DadosCartaoDeCredito { get; set; }
        public int LimiteVeiculo { get; set; }
        public bool BloqueadoPacoteSMS { get; set; }
        public bool PacoteSms { get; set; }
        //[DataType(DataType.Password)]
        public string SenhaUra { get; set; }
        public bool EmitirNotaFiscal { get; protected set; }
        public bool UltimaCobrancaPaga { get; protected set; }
        public DateTime DataUltimaAtualizacaoCobranca { get; protected set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
       // public CanalVendas CanalVendas { get; set; }
        public DateTime DataAlteracaoStatus { get; protected set; }
        public DateTime? DataValidacaoEmail { get; protected set; }
       // public IList<ChaveCliente> ChaveCliente { get; protected set; }
        public bool ClienteGestaoFrotas { get; set; }
        public bool TentativaCadastroDivergente { get; set; }
        //public DetalheRestricaoTransferencia Restricao { get; set; }
        public bool SituacaoBloqueioTransferencia { get; set; }
        public DateTime? DataCadastroDivergente { get; set; }
        //public EnumInfo<StatusSerasa> StatusSerasa { get; set; }
        public bool PermiteEnvioSms { get; set; }
        #endregion Propriedades
    }
}