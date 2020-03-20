using System.ComponentModel.DataAnnotations;

namespace App1.Web.Models.UsuarioViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha de acesso")]
        [StringLength(20, ErrorMessage = "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres", MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha de acesso")]
        [Compare("Password", ErrorMessage ="As senhas devem ser iguais")]
        [StringLength(20, ErrorMessage = "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres", MinimumLength = 8)]
        public string ConfirmPassword { get; set; }
    }
}