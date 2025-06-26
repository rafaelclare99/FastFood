using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "o nome do lanche deve ser informado")]
        [Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "o nome tem que ter no maximo 20 caracteres")]
        public string LancheNome { get; set; }

        [Required(ErrorMessage = "a descrição do lanche deve ser informado")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(100, ErrorMessage = "a descrição tem que ter no minimo 100 caracteres")]
        [MaxLength(200, ErrorMessage = "o nome tem que ter no maximo 200 caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "a descrição do lanche deve ser informado")]
        [Display(Name = "Descrição do Lanche Detalhada")]
        [MinLength(100, ErrorMessage = "a descrição tem que ter no minimo 20 caracteres")]
        [MaxLength(200, ErrorMessage = "o nome tem que ter no maximo 200 caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o valor do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve está entre 1 a 999,999")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da imagem")]
        public string ImagemUrl { get; set; }

        [Display(Name = "caminho imagem minhatura")]
        public string ImagemThumb { get; set; }

        [Display(Name = "Prefiro ?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}