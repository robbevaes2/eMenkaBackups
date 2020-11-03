using System.ComponentModel.DataAnnotations;

namespace eMenka.API.AuthenticationModels
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        //TODO: Add other properties, unknown for now.
    }
}
