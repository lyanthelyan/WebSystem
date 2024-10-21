using Microsoft.EntityFrameworkCore;
using SalesWebApplication.Models;

namespace SalesWebApplication.Data
{
    public class SalesWebApplicationContext : DbContext
    {
        public SalesWebApplicationContext (DbContextOptions<SalesWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        
    }
}
