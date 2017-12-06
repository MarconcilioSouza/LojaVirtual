namespace LojaVirtual.Dominio.Entidades
{
    public partial class InstituicaoFinanceira
    {
        public  int Codigo { get; set; }
        public  string Descricao { get; set; }
        public  bool Ativo { get; set; }
        public  ConfiguracaoIntegracaoBancaria ConfiguracaoIntegracaoBancaria { get; set; }
    }
}