using DatabaseService;

namespace AuthorizationService.JwtToken.Models
{
    public class UserPermission
    {
        public int Id { get; set; }
        public string Permission { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}