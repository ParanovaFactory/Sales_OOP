using Microsoft.EntityFrameworkCore;
using Sales_OOP.Entity;

namespace Sales_OOP.ProjectContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=PREDATOR;database=DbCoreSales;integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cathegory> Cathegories { get; set; }
    }
}
