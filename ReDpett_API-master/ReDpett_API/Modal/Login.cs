using System.ComponentModel.DataAnnotations;

namespace ReDpett_API.Modal
{
    public class Login
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

    }
}
