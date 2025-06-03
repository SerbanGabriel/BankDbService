using AuthorizationService.JwtToken.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseService
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<UserPermission> Permissions { get; set; }
    }
}
