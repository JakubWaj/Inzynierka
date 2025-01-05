using Application.Abstraction;
using Application.Features.Reviews;

namespace Application.Features.Movies.Queries.GetMainPage;

public class GetMainPageQueryHandler : IQueryHandler<GetMainPageQuery,IEnumerable<MainPageDto>>
{
    private readonly IMovieRepository _repository;
    private readonly IReviewRepository _reviewRepository;

    public GetMainPageQueryHandler(IMovieRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<MainPageDto>> HandleAsync(GetMainPageQuery query)
    {
        throw new NotImplementedException();
    }
}