namespace api.Models
{
    public class UserRole
    {
        public string RoleId { get; set; }
        public string Id { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}