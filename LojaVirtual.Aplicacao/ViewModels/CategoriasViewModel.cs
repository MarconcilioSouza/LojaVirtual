using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Aplicacao.ViewModels
{
    public class CategoriasViewModel
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage ="Prencha o campo Nome")]
        [MaxLength(15,ErrorMessage ="Máximo {0} caracteres")]
        public string NomeCategoria { get; set; }
        [MaxLength(400, ErrorMessage = "Máximo {0} caracteres")]
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
    }
}