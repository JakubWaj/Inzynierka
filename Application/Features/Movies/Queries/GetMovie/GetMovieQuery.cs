using Application.Abstraction;

namespace Application.Features.Movies.Queries.GetMovie;

public record GetMovieQuery(Guid Id) : IQuery<MovieDto>;
