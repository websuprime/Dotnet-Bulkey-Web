using Bulkey_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulkey_Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        // You can add your DbSet properties here
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}
