using API.Controllers;
using Application.Abstraction;
using Application.Features.Reviews.Commands.AddReview;
using Application.Features.Reviews.Commands.DeleteReview;
using Application.Features.Reviews.Commands.UpdateReview;
using Application.Features.Reviews.Queries.GetReview;
using Application.Features.Reviews.Queries.GetReviews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.Review;

public class ReviewController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public ReviewController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetReviewAsync(Guid id)
    {
        var review = new GetReviewQuery(){Id = id};
        var result = await _queryDispatcher.SendAsync(review);
        return Ok(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetReviewsAsync()
    {
        var reviews = new GetReviewsQuery();
        var result = await _queryDispatcher.SendAsync(reviews);
        return Ok(result);
    }
    
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> CreateReviewAsync(ReviewRequests reviewRequest)
    {
        var id = Guid.NewGuid();
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var guid = Guid.Parse(User.Identity?.Name);
        
        var command = new AddReviewCommand
        {
            Id = id,
            Rating = reviewRequest.Rating,
            MovieId = reviewRequest.MovieId,
            UserId = guid
            ,Comment = reviewRequest.Comment
        };
        
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id= id,
            Result= result
        });
    }
    
    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteReviewAsync(Guid id)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var guid = Guid.Parse(User.Identity?.Name);
        
        var command = new DeleteReviewCommand
        {
            Id = id,
            UserId = guid
        };
        await _commandDispatcher.SendAsync(command);
        return Accepted();
    }
    
    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> UpdateReviewAsync(Guid id, ReviewRequests reviewRequest)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var guid = Guid.Parse(User.Identity?.Name);

        var command = new UpdateReviewCommand
        {
            Id = id,
            Rating = reviewRequest.Rating,
            MovieId = reviewRequest.MovieId,
            Comment = reviewRequest.Comment,
            UserId = guid
        };
        await _commandDispatcher.SendAsync(command);
        return Accepted();
    }

}