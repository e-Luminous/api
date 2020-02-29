using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Mobile { get; set; }

        public string PasswordHash { get; set; }

        public bool MobileConfirmed { get; set; }

        public bool EmailConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }
        
        public bool LockoutEnabled { get; set; }

        public ICollection<UserRole> Roles { get; set; }
    }
}