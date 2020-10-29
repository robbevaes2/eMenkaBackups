using eMenka.Domain;
using System.ComponentModel.DataAnnotations;

namespace eMenka.Business.Models
{
    public class ProfileModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string UserName { get; set; }

        public ProfileModel()
        {

        }

        public ProfileModel(User entity)
        {
            Id = entity.Id;
            Email = entity.Email;
            UserName = entity.Email;
        }
    }
}
