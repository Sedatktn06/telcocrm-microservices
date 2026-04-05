using CoreDomain;

namespace Domain.Entities;

public class City : BaseEntity<short>
{
    public string Name { get; set; }

    public ICollection<District> Districts { get; set; }
    public City()
    {
        Districts = new HashSet<District>();
    }

    public City(short id, string name) : this()
    {
        Id = id;
        Name = name;
    }

}   
