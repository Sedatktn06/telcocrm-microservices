using CoreDomain;

namespace Domain.Entities;

public class Customer: BaseEntity<Guid>
{
    public string CustomerNumber { get; set; }

    public virtual ICollection<BillingAccount> BillingAccounts { get; set; }

    public Customer()
    {
        BillingAccounts = new HashSet<BillingAccount>();
    }
}
