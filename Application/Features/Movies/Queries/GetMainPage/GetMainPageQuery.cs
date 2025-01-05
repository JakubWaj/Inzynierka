using Application.Abstraction;

namespace Application.Features.Movies.Queries.GetMainPage;

public class GetMainPageQuery : IQuery<IEnumerable<MainPageDto>>
{
    public Guid UserId { get; set; }
}