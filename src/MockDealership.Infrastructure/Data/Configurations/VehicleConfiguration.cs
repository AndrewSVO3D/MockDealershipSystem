using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MockDealership.Domain.Entities;

namespace MockDealership.Infrastructure.Data.Configurations;

public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.Property(v => v.Vin).HasMaxLength(17).IsRequired();
        builder.HasIndex(v => v.Vin).IsUnique();
        builder.Property(v => v.Make).HasMaxLength(50).IsRequired();
        builder.Property(v => v.Model).HasMaxLength(50).IsRequired();
        builder.Property(v => v.Price).HasPrecision(12, 2);
        builder.Property(v => v.Status).HasConversion<string>().HasMaxLength(20);
    }
}
