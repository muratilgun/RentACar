using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;


namespace RentACar.Persistence.EntityConfigurations;
public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
        builder.Property(b => b.CreatedAt).HasColumnName("CreatedAt").IsRequired();
        builder.Property(b => b.UpdatedAt).HasColumnName("UpdatedAt");
        builder.Property(b => b.DeletedAt).HasColumnName("DeletedAt");

        builder.HasIndex(b => b.Name, "UK_Brands_Name").IsUnique();

        builder.HasMany(b => b.Models);

        builder.HasQueryFilter(b => !b.DeletedAt.HasValue);
    }
}
