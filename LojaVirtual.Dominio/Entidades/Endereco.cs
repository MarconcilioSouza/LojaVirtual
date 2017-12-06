using System;

namespace LojaVirtual.Dominio.Entidades
{
    public partial class Endereco
    {
        public virtual bool AcessoOperacional { get; set; }
        public virtual DateTime DataDeCadastro { get; protected set; }
        public virtual string Cep { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Bairro { get; set; }

    }
}
