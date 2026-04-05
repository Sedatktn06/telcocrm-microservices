using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityTypeConfigurations;

public class BillingAccountConfiguration : IEntityTypeConfiguration<BillingAccount>
{
    public void Configure(EntityTypeBuilder<BillingAccount> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CustomerId).IsRequired();
        builder.Property(x => x.BillingAddressId).IsRequired();
        builder.Property(x => x.Number).IsRequired();
        builder.HasIndex(x => x.Number).IsUnique();
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Description).IsRequired();

        builder.HasOne(x => x.Customer);
        builder.HasOne(x => x.BillingAddress);

        builder.HasQueryFilter(x => !x.DeletedDate.HasValue);
        builder.HasBaseType((string)null!);
    }
}   
