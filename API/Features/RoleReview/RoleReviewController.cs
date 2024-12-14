using API.Controllers;
using API.Features.Role;
using Application.Abstraction;
using Application.Features.Reviews.Queries.GetReview;
using Application.Features.RoleReview.Command.AddRoleReview;
using Application.Features.RoleReview.Command.DeleteRoleReview;
using Application.Features.RoleReview.Command.UpdateRoleReview;
using Application.Features.RoleReview.Queries.GetRoleReviews;
using Application.Features.Roles.Commands.DeleteRole;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.RoleReview;

public class RoleReviewController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public RoleReviewController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }
    
      [HttpGet("{id}")]
      public async Task<IActionResult> GetRoleReview(Guid id)
      {
          var query = new GetReviewQuery { Id = id };
          var review = await _queryDispatcher.SendAsync(query);
          return Ok(review);
      }
      [HttpGet("role/{id}")]
      public async Task<IActionResult> GetRoleReviews(Guid id)
      {
          var query = new GetRoleReviewsQuery { RoleId = id };
          var reviews = await _queryDispatcher.SendAsync(query);
          return Ok(reviews);
      }
      [HttpPost]
      [Authorize]
      public async Task<IActionResult> UpdateRoleReview(RoleReviewRequest request)
      {
          var newGuid = Guid.NewGuid();
          if(User.Identity?.Name is null)
          {
              return NotFound();
          }

          var id = Guid.Parse(User.Identity?.Name);

          var command = new AddRoleReviewCommand() {Id = newGuid,UserId = id, RoleId = request.RoleId, Rating = request.Rating };
          var result = await _commandDispatcher.SendAsync(command);
          return Ok(result);
      }
      [HttpDelete("{id}")]
      [Authorize]
      public async Task<IActionResult> DeleteRoleReview(Guid id)
      {
          var command = new DeleteRoleReviewCommand() { Id = id };
          var result = await _commandDispatcher.SendAsync(command);
          return Ok(result);
      }
      [HttpPut("{id}")]
      [Authorize]
      public async Task<IActionResult> UpdateRoleReview(RoleReviewRequest roleRequests,Guid id)
      {
          var Id = Guid.NewGuid();
          if(User.Identity?.Name is null)
          {
              return NotFound();
          }

          var command = new UpdateRoleReviewCommand()
              { RoleId = roleRequests.RoleId, Rating = roleRequests.Rating, UserId = Id, Id = id };
          var result = await _commandDispatcher.SendAsync(command);
          return Ok(result);
      }
}