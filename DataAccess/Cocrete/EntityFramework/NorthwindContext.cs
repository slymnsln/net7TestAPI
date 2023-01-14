using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Cocrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P9VVNF2;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-P9VVNF2;Database=Northwind;User Id=sa;Password=s123s;TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
