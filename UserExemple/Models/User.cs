using System.ComponentModel.DataAnnotations;

namespace UserExemple.Models
    
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }

}
