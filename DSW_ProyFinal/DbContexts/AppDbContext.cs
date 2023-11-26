using Microsoft.EntityFrameworkCore;
using DSW_ProyFinal.Models;

namespace DSW_ProyFinal.DbContexts
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() { 
        }

        public AppDbContext(DbContextOptions options):base(options) {
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Client> Clients { get; set;}
        public DbSet<Order> Orders { get; set;}
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
