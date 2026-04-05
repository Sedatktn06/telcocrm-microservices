using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityTypeConfigurations;

public class ContactMediumConfiguration : IEntityTypeConfiguration<ContactMedium>
{
    public void Configure(EntityTypeBuilder<ContactMedium> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CustomerId).IsRequired();
        builder.Property(x => x.ContactMediumType).IsRequired();
        builder.Property(x => x.Value).IsRequired();
        builder.Property(x => x.IsPrimary).IsRequired();


        builder.HasOne(x => x.Customer);

        builder.HasQueryFilter(x => !x.DeletedDate.HasValue);
        builder.HasBaseType((string)null!);
    }
}