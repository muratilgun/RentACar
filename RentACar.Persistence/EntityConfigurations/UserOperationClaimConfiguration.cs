using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RentACar.Persistence.EntityConfigurations;
public class UserOperationClaimConfiguration : IEntityTypeConfiguration<UserOperationClaim>
{
    public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
    {
        builder.ToTable("UserOperationClaims").HasKey(uoc => uoc.Id);

        builder.Property(uoc => uoc.Id).HasColumnName("Id").IsRequired();
        builder.Property(uoc => uoc.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(uoc => uoc.OperationClaimId).HasColumnName("OperationClaimId").IsRequired();
        builder.Property(uoc => uoc.CreatedAt).HasColumnName("CreatedAt").IsRequired();
        builder.Property(uoc => uoc.UpdatedAt).HasColumnName("UpdatedAt");
        builder.Property(uoc => uoc.DeletedAt).HasColumnName("DeletedAt");

        builder.HasQueryFilter(uoc => !uoc.DeletedAt.HasValue);

        builder.HasOne(uoc => uoc.User);
        builder.HasOne(uoc => uoc.OperationClaim);

        builder.HasData(getSeeds());
    }

    private IEnumerable<UserOperationClaim> getSeeds()
    {
        List<UserOperationClaim> userOperationClaims = new();

        UserOperationClaim adminUserOperationClaim = new(id: Guid.Parse("8025cdc3-0baa-4533-bd01-703275948368"), userId: Guid.Parse("6a17fa3d-2003-4b50-b9a5-882c9867be8e"), operationClaimId: Guid.Parse("0c05cb4f-fc6e-40d9-b7a7-f695a4fc05e9"));
        userOperationClaims.Add(adminUserOperationClaim);

        return userOperationClaims;
    }
}