using Backend_Project.Models;
using Microsoft.EntityFrameworkCore;


namespace Backend_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SameBannerArea> SameBannerAreas { get; set; }
        public DbSet<Blog> Blogs { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        }
}
