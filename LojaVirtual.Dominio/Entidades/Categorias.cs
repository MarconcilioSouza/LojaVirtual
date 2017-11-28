namespace LojaVirtual.Dominio.Entidades
{
    public partial class Categorias
    {
        public Categorias()
        {
        }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
    }
}
