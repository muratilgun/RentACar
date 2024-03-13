using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RentACar.Persistence.EntityConfigurations;
public class EmailAuthenticatorConfiguration : IEntityTypeConfiguration<EmailAuthenticator>
{
    public void Configure(EntityTypeBuilder<EmailAuthenticator> builder)
    {
        builder.ToTable("EmailAuthenticators").HasKey(ea => ea.Id);

        builder.Property(ea => ea.Id).HasColumnName("Id").IsRequired();
        builder.Property(ea => ea.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(ea => ea.ActivationKey).HasColumnName("ActivationKey");
        builder.Property(ea => ea.IsVerified).HasColumnName("IsVerified").IsRequired();
        builder.Property(ea => ea.CreatedAt).HasColumnName("CreatedAt").IsRequired();
        builder.Property(ea => ea.UpdatedAt).HasColumnName("UpdatedAt");
        builder.Property(ea => ea.DeletedAt).HasColumnName("DeletedAt");

        builder.HasQueryFilter(ea => !ea.DeletedAt.HasValue);

        builder.HasOne(ea => ea.User);
    }
}