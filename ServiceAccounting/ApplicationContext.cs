using Microsoft.EntityFrameworkCore;
using ServiceAccounting.Model;
using System;

namespace ServiceAccounting;

internal class ApplicationContext : DbContext
{
    public class CompanyProductsGroup
    {
        public string? Name { get; set; }
        public string? ProductName { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<CompanyProductsGroup> ProductsByCompany { get; set; } = null!;


    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;" +
        //    "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        optionsBuilder.UseSqlite("Data Source=lite.db");
        //optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q9PBDCE;Integrated Security=True;Connect Timeout=30;" +
        //    "Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
                .Entity<Customer>()
                .HasMany(c => c.Products)
                .WithMany(s => s.Customers)
                .UsingEntity<Purchase>(
                   j => j
                    .HasOne(pt => pt.Product)
                    .WithMany(t => t.Purchases)
                    .HasForeignKey(pt => pt.ProductId),
                j => j
                    .HasOne(pt => pt.Customer)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(pt => pt.CustomerId),
                j =>
                {
                    j.Property(pt => pt.Date).HasDefaultValueSql("CURRENT_TIMESTAMP");
                    j.Property(pt => pt.Count).HasDefaultValue(1);
                    j.HasKey(t => t.Id);
                    j.ToTable("Purchases");
                });

        modelBuilder.Entity<CompanyProductsGroup>(pc =>
        {
            pc.HasNoKey();
            pc.ToView("CustomersTotalSumView");
        });
    }
}
