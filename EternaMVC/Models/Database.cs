using Microsoft.EntityFrameworkCore;

namespace EternaMVC.Models
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioImage> PortfolioImages { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Count> Count { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamSocialMediaAccount> TeamSocialMediaAccounts { get; set; }


    }
}
