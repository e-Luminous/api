using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CustomModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string UserName { get; set; }
        [Required]
        public string Mobile { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        public string Role { get; set; }
    }
}