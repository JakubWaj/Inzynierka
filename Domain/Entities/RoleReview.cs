namespace Domain.Entities;

public class RoleReview
{
    public Guid Id { get; set; }
    public virtual Role Role { get; set; }
    public Guid RoleId { get; set; }
    public virtual User User { get; set; }
    public Guid UserId { get; set; }
    public int Rating { get; set; }
}