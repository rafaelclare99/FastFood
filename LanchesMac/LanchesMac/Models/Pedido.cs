using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "informe o sobrenome")]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "informe o Endereço")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco1 { get; set; }

        [Required(ErrorMessage = "informe o Endereço")]
        [StringLength(100)]
        [Display(Name = "Complemento")]
        public string Endereco2 { get; set; }

        [Required(ErrorMessage = "informe o CEP")]
        [StringLength(10, MinimumLength = 8)]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "informe o Estado")]
        [StringLength(10)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "informe a Cidade")]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "informe o Número para contato")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "informe o E-mail")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
          ErrorMessage = "O email não possui formato correto")]
        public string Email { get; set; }


        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Total do pedido")]
        public string PedidoTotal { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Itens no pedido ")]
        public string TotalItensPedido { get; set; }
    }
}
