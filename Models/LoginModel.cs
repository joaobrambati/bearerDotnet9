using System.ComponentModel.DataAnnotations;

namespace teste.Models
{
    public class LoginModel
    {
        [Key]
        public int IdUser { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
