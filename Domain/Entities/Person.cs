namespace Domain.Entities;

public class Person
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Biography { get; set; }
    public ICollection<Role> Roles { get; set; }
    public string? Image { get; set; }
}