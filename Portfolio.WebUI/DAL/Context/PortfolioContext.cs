using Microsoft.EntityFrameworkCore;
using MyPortfolio.WebUI.DAL.Entities;

namespace MyPortfolio.WebUI.DAL.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\local;Database=Portfolio;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<SeoSetting> SeoSettings { get; set; }
        public DbSet<SiteSetting> SiteSettings { get; set; }

    }
}
