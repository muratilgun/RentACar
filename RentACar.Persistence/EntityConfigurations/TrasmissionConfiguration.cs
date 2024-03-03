using RentACar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace RentACar.Persistence.EntityConfigurations;

public class TrasmissionConfiguration : IEntityTypeConfiguration<Transmission>
{
    public void Configure(EntityTypeBuilder<Transmission> builder)
    {
        builder.ToTable("Transmissions").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
        builder.Property(b => b.CreatedAt).HasColumnName("CreatedAt").IsRequired();
        builder.Property(b => b.UpdatedAt).HasColumnName("UpdatedAt");
        builder.Property(b => b.DeletedAt).HasColumnName("DeletedAt");

        builder.HasIndex(b => b.Name, "UK_Transmissions_Name").IsUnique();

        builder.HasMany(b => b.Models);

        builder.HasQueryFilter(b => !b.DeletedAt.HasValue);
    }
}
