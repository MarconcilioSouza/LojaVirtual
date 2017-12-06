namespace LojaVirtual.Dominio.Entidades
{
    public class ParametrosIntegracaoBancaria
    {
        public virtual string Chave { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Valor { get; set; }
        public virtual ConfiguracaoIntegracaoBancaria ConfiguracaoIntegracaoBancaria { get; set; }
    }
}