using Domain.Common.Enums;

namespace Domain.Entities;

public class Role
{
    public Guid PersonId { get; set; }
    public virtual Person Person { get; set; }
    public Guid MovieId { get; set; }
    public virtual Movie Movie { get; set; }
    public MovieProductionRole MovieProductionRole { get; set; }
    public string? Character { get; set; }
}