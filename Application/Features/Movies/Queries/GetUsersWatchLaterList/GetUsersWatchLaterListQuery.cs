using Application.Abstraction;

namespace Application.Features.Movies.Queries.GetUsersWatchLaterList;

public class GetUsersWatchLaterListQuery : IQuery<IEnumerable<MovieDto>>
{
    public Guid UserId { get; set; }
}