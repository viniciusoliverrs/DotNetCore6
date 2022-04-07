using System.ComponentModel.DataAnnotations;

namespace AuthNetCore6.ViewModel.Request
{
    public class RegisterRequest
    {
        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        public string Username { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(10)]
        public string Password { get; set; }
    }
}
