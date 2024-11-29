using Domain.Common.Enums;

namespace Application.Features.Movies;

public record MovieDto(Guid Id,string Title, string Description, Genre Genre, DateTime ReleaseDate, int BoxOffice, int Duration);