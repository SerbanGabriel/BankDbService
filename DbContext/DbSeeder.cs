using AuthorizationService.JwtToken.Models;

namespace DatabaseService.Data
{
    public class DbSeeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (!context.Users.Any(u => u.Role == "Admin"))
            {
                context.Users.Add(new User
                {
                    Email = "admin@bank.com",
                    Password = HashPassword("admin123"),
                    Role = "Admin",
                    Permissions = new List<UserPermission>
                    {
                        new UserPermission { Permission = "read:users" },
                        new UserPermission { Permission = "write:users" },
                        new UserPermission { Permission = "delete:users" },
                        new UserPermission { Permission = "edit:users" },
                        new UserPermission { Permission = "create:users" },

                    },
                    CreatedAt = DateTime.UtcNow
                });
                await context.SaveChangesAsync();
            }
        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
