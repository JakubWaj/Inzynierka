using Domain.Common;

namespace Domain.Entities;

public class Review : AuditableEntity
{
    public Guid Id { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
    public Guid MovieId { get; set; }
    public virtual Movie Movie { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
}