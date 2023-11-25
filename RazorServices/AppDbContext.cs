using Microsoft.EntityFrameworkCore;
using RazorModels;

namespace RazorServices
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}

