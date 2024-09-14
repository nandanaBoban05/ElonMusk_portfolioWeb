using ElonMusk_portfolioWeb.Models.Enitites;
using Microsoft.EntityFrameworkCore;
namespace ElonMusk_portfolioWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
       public DbSet<Contact>  Contacts { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
