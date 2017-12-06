using System.ComponentModel;

namespace LojaVirtual.Dominio.Enum
{
    public enum EstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        [Description("Viúvo")]
        Viuvo = 3,
        Divorciado = 4,
        Separado = 5
    }
}
