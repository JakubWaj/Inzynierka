using Domain.Common;

namespace Domain.Entities;

public class Country
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<MovieCountry> Productions { get; set; }
}