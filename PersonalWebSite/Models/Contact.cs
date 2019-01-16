using System.ComponentModel.DataAnnotations;

namespace PersonalWebSite.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Please enter your name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        [MaxLength(50)]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        public string Message { get; set; }
    }
}