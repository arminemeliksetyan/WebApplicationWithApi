using System.ComponentModel.DataAnnotations;

namespace WebApplicationApi.Models
{
    public class UserModel
    {
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(11)]
        public string Phone { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(300)]
        public string Login { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(300)]
        public string Password { get; set; }
    }
}
