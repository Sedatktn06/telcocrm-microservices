using CoreDomain;
using Domain.Enums;

namespace Domain.Entities;

public class BillingAccount : BaseEntity<Guid>
{
    public Guid CustomerId { get; set; }
    public Guid BillingAddressId { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public string Description { get; set; }

    public BillingAccountType BillingAccountType { get; set; }
    public BillingAccountStatus BillingAccountStatus { get; set; }

    public virtual Customer Customer { get; set; }
    public virtual Address BillingAddress  { get; set; }


    public BillingAccount()
    {
        
    }

    public BillingAccount(Guid id, Guid customerId, Guid billingAddressId, string name, string number, string description, BillingAccountType billingAccountType, BillingAccountStatus billingAccountStatus): this()
    {
        Id = id;
        CustomerId = customerId;
        BillingAddressId = billingAddressId;
        Name = name;
        Number = number;
        Description = description;
        BillingAccountType = billingAccountType;
        BillingAccountStatus = billingAccountStatus;
    }
}
