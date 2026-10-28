using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MockDealership.Domain.Entities;

namespace MockDealership.Infrastructure.Data.Configurations;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.Property(s => s.SalePrice).HasPrecision(12, 2);

        // A vehicle can only be sold once
        builder.HasOne(s => s.Vehicle)
            .WithOne(v => v.Sale)
            .HasForeignKey<Sale>(s => s.VehicleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.Customer)
            .WithMany(c => c.Purchases)
            .HasForeignKey(s => s.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
