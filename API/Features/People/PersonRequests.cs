using Domain.Common.Enums;

namespace API.Features.People;

public record PersonRequests(string FirstName,string LastName,DateTime BirthDate,string Biography);
