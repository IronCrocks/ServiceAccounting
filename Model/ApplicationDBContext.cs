using Microsoft.EntityFrameworkCore;
using Model.Entites;

namespace ServiceAccounting;

public class ApplicationDBContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;" +
        //    "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        
        var path = Path.Combine(AppContext.BaseDirectory, "lite1.db");
        optionsBuilder.UseSqlite($"Data Source={path}");
        
        //optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q9PBDCE;Integrated Security=True;Connect Timeout=30;" +
        //    "Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
