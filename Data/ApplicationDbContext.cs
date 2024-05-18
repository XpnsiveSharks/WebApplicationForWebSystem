using Microsoft.EntityFrameworkCore;
using WebApplicationForWebSystem.Models;

namespace WebApplicationForWebSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Test", DisplayOrder = 3},
                new Category { Id = 2, Name = "Test2", DisplayOrder = 4 },
                new Category { Id = 3, Name = "Test3", DisplayOrder = 5 }
                );
        }
    }
}
