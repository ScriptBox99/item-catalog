﻿namespace WebApi.Services;

public interface ICurrentUserService
{
    string UserId { get; }
}