using System.ComponentModel.DataAnnotations;

namespace ReDpett_API.Modal
{
    public class Register
    {
        [Required(ErrorMessage = "Id is required")]
        public string? Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? UserType { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? FETPProgram { get; set; }
    }
}
