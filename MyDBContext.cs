using InventoryManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
