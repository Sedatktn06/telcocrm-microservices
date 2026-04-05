using CoreDomain;
using Domain.Enums;

namespace Domain.Entities;

public class ContactMedium : BaseEntity<Guid>
{
    public Guid CustomerId { get; set; }
    public ContactMediumType ContactMediumType { get; set; }
    public string Value { get; set; }
    public bool IsPrimary { get; set; }

    public virtual Customer Customer { get; set; }

    public ContactMedium()
    {
        
    }

    public ContactMedium(Guid ıd, Guid customerId, ContactMediumType contactMediumType, string value, bool ısPrimary, Customer customer): this()
    {
        Id = ıd;
        CustomerId = customerId;
        ContactMediumType = contactMediumType;
        Value = value;
        IsPrimary = ısPrimary;
        Customer = customer;
    }
}
