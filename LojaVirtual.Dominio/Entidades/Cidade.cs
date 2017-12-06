namespace LojaVirtual.Dominio.Entidades
{
    public class Cidade
    {
        public virtual Estado Estado { get; set; }
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }
        public virtual bool Capital { get; set; }
    }
}