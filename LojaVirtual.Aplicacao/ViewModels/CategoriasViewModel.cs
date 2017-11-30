using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Aplicacao.ViewModels
{
    public class CategoriasViewModel
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "Prencha o campo Nome")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Categoria")]
        public string NomeCategoria { get; set; }
        [MaxLength(400, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Imagem")]
        public byte[] Imagem { get; set; }
    }
}