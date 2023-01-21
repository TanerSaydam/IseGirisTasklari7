using IseGirisTasklari7.Domain.Entities;
using IseGirisTasklari7.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IseGirisTasklari7.Persistance.Configurations;

public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(TableNames.Orders);
        builder.HasKey(p => p.Id);

        builder
            .HasOne(p => p.Product)
            .WithMany(p => p.Orders)
            .HasForeignKey(p => p.ProductId);
    }
}
