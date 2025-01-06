using Application.Abstraction;

namespace Application.Features.Movies.Queries.GetMainPage;

public class GetMainPageQuery : IQuery<IEnumerable<MainPageMovieDto>>
{
    public Guid UserId { get; set; }
}