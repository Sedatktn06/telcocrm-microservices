namespace Domain.Entities;

public class IndividualCustomer: Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdendity { get; set; }
    public DateTime BirthDate { get; set; }

    public IndividualCustomer()
    {
        
    }

    public IndividualCustomer(Guid id,string firstName, string lastName, string nationalIdentity, DateTime birthDate): this()
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        NationalIdendity = nationalIdentity;
        BirthDate = birthDate;
    }
}
