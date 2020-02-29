using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Role
    {
        [Key]
        public string RoleId { get; set; }
        
        public string RoleName { get; set; }
        
        public string NormalizedName { get; set; }

        public ICollection<UserRole> Roles { get; set; }
    }
}