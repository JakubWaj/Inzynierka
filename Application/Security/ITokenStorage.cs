﻿using Application.Features.Users;

namespace Application.Security;

public interface ITokenStorage
{
    void Set(JwtDto jwt);
    JwtDto Get();
}