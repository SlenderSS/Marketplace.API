using ApiMarketplace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiMarketplace.Configurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.ToTable("baskets").HasKey(x => x.Id);

        builder
            .HasOne(x => x.User)
            .WithOne(x => x.Basket)
            .HasForeignKey<User>(x => x.BasketId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(x => x.BasketItems)
            .WithOne(x => x.Basket)
            .HasForeignKey(x => x.BasketId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}