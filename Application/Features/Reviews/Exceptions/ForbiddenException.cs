﻿using Application.Shared;

namespace Application.Features.Reviews.Exceptions;

public class ForbiddenException : BaseException
{
    public ForbiddenException(string message) : base(message)
    {
    }
}