using FigureModel.Models;
using Microsoft.EntityFrameworkCore;

namespace Figure.DataAccess.Data
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
                new Category { Id = 1, Name = "Gaming Accessories", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Posters", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Clothes", DisplayOrder = 3 });
        }
    }
}
