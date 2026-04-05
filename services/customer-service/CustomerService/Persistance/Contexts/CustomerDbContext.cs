using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistance.Contexts;

public class CustomerDbContext: EfDbContextBase
{
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options): base(options)
    {
        
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerDbContext).Assembly);
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<ContactMedium> ContactMediums { get; set; }
    public DbSet<BillingAccount> BillingAccounts { get; set; }
}
