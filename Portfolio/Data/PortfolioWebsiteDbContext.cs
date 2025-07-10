using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class PortfolioWebsiteDbContext : DbContext
    {
        public PortfolioWebsiteDbContext(DbContextOptions<PortfolioWebsiteDbContext> options) : base(options)
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
