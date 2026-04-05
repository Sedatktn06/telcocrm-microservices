using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityTypeConfigurations;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.ToTable("individual_customers");
        builder.Property(i => i.FirstName).IsRequired();
        builder.Property(i => i.LastName).IsRequired();
        builder.Property(i => i.NationalIdentity).IsRequired().HasMaxLength(11);
        builder.Property(i => i.BirthDate).IsRequired();
    }
}
