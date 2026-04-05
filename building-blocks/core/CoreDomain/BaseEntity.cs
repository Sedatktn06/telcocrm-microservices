namespace CoreDomain;

public class BaseEntity<TId>
{
    public TId Id { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset? UpdatedDate { get; set; }
    public DateTimeOffset? DeletedDate { get; set; }
}
