using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100,ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "informe o nome da categoria")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "informe a descrição da categoria")]
        [Display(Name = "Nome")]
        public string Descricao { get; set; }

        public List<Lanche>Lanches { get; set; }


    }
}
 