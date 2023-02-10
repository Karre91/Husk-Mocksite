using System.ComponentModel.DataAnnotations;

namespace HuskMock.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(3, ErrorMessage = "Too Short")]        
        public string Subject { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Message { get; set; }
    }
}
