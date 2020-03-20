using System.ComponentModel.DataAnnotations;

namespace App1.Web.Models.UsuarioViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Lembrar login")]
        public bool Rememberme { get; set; }
    }
}