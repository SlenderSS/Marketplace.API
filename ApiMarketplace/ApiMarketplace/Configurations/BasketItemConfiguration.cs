using ApiMarketplace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiMarketplace.Configurations;

public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
{
    public void Configure(EntityTypeBuilder<BasketItem> builder)
    {
        builder.ToTable("basket_item").HasKey(x => x.Id);

        builder
            .HasOne(x => x.Basket)
            .WithMany(x => x.BasketItems)
            .HasForeignKey(x => x.BasketId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
        builder
            .HasOne(x => x.Product)
            .WithMany(x => x.BasketItems)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}