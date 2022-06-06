using C_upsB.Models;
using Microsoft.EntityFrameworkCore;

namespace C_upsB.DataAccesLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
           
        }

        public DbSet<Stylish> Stylish { get; set; }
        public DbSet<AboutImages> AboutImages { get; set; }
        public DbSet<AboutTexts> AboutTexts { get; set; }
        public DbSet<AboutDetail> AboutDetails { get; set; }
        
        public DbSet<Category> Categories {get; set; }
        
        public DbSet<Drink> Drinks { get; set; }


        public DbSet<Location> Locations { get; set; }
        
        public DbSet<Blog> Blogs { get; set; }
        
        public DbSet<BlogRelated> BlogRelateds { get; set; }

        public DbSet<Merchandise> Merchandises { get; set; }
        public DbSet<MerchandiseTypes> MerchandiseTypes { get; set; }

        public DbSet<Thumbs> Thumbs { get; set; }
    }
}