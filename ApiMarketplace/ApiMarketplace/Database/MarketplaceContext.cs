using ApiMarketplace.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMarketplace.Database;

public class MarketplaceContext : DbContext
{
    private readonly IConfiguration _configuration;

    #region DbSets
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Basket> Baskets { get; set; } = null!;
    public DbSet<BasketItem> BasketItems { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderItem> OrderItems { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<Manufacturer> Manufacturers { get; set; } = null!;

    #endregion

    public MarketplaceContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(_configuration.GetConnectionString("MSSQL"))
            .UseLoggerFactory(CreateLoggerFactory())
            .EnableSensitiveDataLogging();
        ;
    }

    public ILoggerFactory CreateLoggerFactory() =>
        LoggerFactory.Create(builder => { builder.AddConsole(); });

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role { Description="sdfsdfsdf", Name="dsdsddsfdfwewew"},
            new Role { Description = "sdfsdfsdf", Name = "dsdsddsfdfwewew" },
            new Role { Description = "sdfsdfsdf", Name = "dsdsddsfdfwewew" }
        );

        // Configure decimal precision and scale
        modelBuilder.Entity<Order>()
            .Property(o => o.TotalAmount)
            .HasColumnType("decimal(18,2)");


        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

        // Configure relationships
        





        modelBuilder.Entity<Product>()
            .HasMany(p => p.BasketItems)
            .WithOne(bi => bi.Product)
            .HasForeignKey(bi => bi.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Basket>()
            .HasMany(b => b.BasketItems)
            .WithOne(bi => bi.Basket)
            .HasForeignKey(bi => bi.BasketId)
            .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<OrderItem>()
            .HasKey(oi => new { oi.OrderId, oi.ProductId });

        modelBuilder.Entity<Product>()
            .HasMany(p => p.Images)
            .WithOne(pi => pi.Product)
            .HasForeignKey(pi => pi.ProductId);

        modelBuilder.Entity<ProductImage>()
            .Property(pi => pi.ImageUrl)
            .IsRequired();
    }
}