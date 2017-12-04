using System.Collections.Generic;

namespace LojaVirtual.Dominio.Entidades
{
    public partial class Fornecedores
    {
        public Fornecedores()
        {

        }

        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }

        public virtual ICollection<Produtos> Produtos { get; set; }
    }
}
