using Application.Abstraction;

namespace Application.Features.Movies.Queries;

public record GetMovieQuery(Guid Id) : IQuery<MovieDto>;
