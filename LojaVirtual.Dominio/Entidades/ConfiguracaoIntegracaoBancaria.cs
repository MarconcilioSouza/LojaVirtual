using System.Collections.Generic;

namespace LojaVirtual.Dominio.Entidades
{
    public class ConfiguracaoIntegracaoBancaria
    {
       // public virtual EnumInfo<TipoIntegracaoBancaria> TipoIntegracaoBancaria { get; set; }
        public  IList<ParametrosIntegracaoBancaria> ParametrosIntegracao { get; set; }
        public virtual bool GeraCodigoAutorizacao { get; set; }
        public virtual string Descricao { get; set; }

        public virtual bool Ativo { get; set; }
    }
}