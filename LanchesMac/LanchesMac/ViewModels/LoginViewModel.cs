using System.ComponentModel.DataAnnotations;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Informe o Usuario ")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Informe o Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

    }
}
