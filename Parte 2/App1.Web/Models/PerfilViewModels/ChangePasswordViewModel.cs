using System.ComponentModel.DataAnnotations;

namespace App1.Web.Models.PerfilViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha atual")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        [
            StringLength(
                100,
                ErrorMessage =
                    "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres!",
                MinimumLength = 8)
        ]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nova senha")]
        [
            Compare(
                "NewPassword",
                ErrorMessage =
                    "O campo \"Nova Senha\" e \"Confirmar nova senha\" devem ter o mesmo valor!")
        ]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
