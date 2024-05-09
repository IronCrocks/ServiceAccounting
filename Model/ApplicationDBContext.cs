using Microsoft.EntityFrameworkCore;
using Model.Data;

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

        optionsBuilder.UseSqlite("Data Source=lite1.db");
        //optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q9PBDCE;Integrated Security=True;Connect Timeout=30;" +
        //    "Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder
        //        .Entity<Order>()
        //        .HasMany(c => c.Products)
        //        .WithMany(s => s.Orders)
        //        .UsingEntity<OrderItem>(
        //           j => j
        //            .HasOne(pt => pt.Product)
        //            .WithMany(t => t.OrderItems)
        //            .HasForeignKey(pt => pt.ProductId),
        //        j => j
        //            .HasOne(pt => pt.Order)
        //            .WithMany(p => p.OrderItems)
        //            .HasForeignKey(pt => pt.OrderId),
        //        j =>
        //        {
        //            j.Property(pt => pt.Count).HasDefaultValue(1);
        //            j.HasKey(t => t.Id);
        //            j.ToTable("OrderItems");
        //        });

        //j.Property(pt => pt.Date).HasDefaultValueSql("CURRENT_TIMESTAMP");

        //modelBuilder.Entity<CompanyProductsGroup>(pc =>
        //{
        //    pc.HasNoKey();
        //    pc.ToView("CustomersTotalSumView");
        //});
    }
}
