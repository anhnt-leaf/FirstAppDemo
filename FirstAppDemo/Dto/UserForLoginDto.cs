using System.ComponentModel.DataAnnotations;

namespace FirstAppDemo.Dto
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must input password from 4 to 8 characters!")]
        public string Password { get; set; }
    }
}