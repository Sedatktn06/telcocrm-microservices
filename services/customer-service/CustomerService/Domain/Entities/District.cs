using CoreDomain;

namespace Domain.Entities;

public class District : BaseEntity<short>
{
    public string Name { get; set; }
    public short CityId { get; set; }

    public City City { get; set; }
    public ICollection<Address> Addresses { get; set; }

    public District(short id, string name, short cityId) : this() 
    {
        Id = id;
        Name = name;
        CityId = cityId;
    }

    public District()
    {
        Addresses = new HashSet<Address>();
    }
}