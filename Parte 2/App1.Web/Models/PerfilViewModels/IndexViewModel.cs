using System.ComponentModel.DataAnnotations;

namespace App1.Web.Models.PerfilViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Número de telefone")]
        public string Phonenumber { get; set; }


        public string StatusMessage { get; set; }

    }
}