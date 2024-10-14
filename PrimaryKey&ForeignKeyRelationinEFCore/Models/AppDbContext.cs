using Microsoft.EntityFrameworkCore;

namespace PrimaryKey_ForeignKeyRelationinEFCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }

    }
}
