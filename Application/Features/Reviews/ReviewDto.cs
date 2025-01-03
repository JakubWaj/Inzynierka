﻿namespace Application.Features.Reviews;

public class ReviewDto
{
    public Guid Id { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
    public Guid MovieId { get; set; }
    public Guid UserId { get; set; }
}