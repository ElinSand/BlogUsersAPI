using Microsoft.EntityFrameworkCore;

namespace BlogUsersAPI.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.User> Users { get; set; }
    }
}
