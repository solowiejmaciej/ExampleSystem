﻿using AuthService.Api.Models.Requests.Login;
using FluentValidation;

namespace AuthService.Api.Models.Validation.RequestValidation
{
    public class UserLoginRequestValidation : AbstractValidator<UserLoginRequest>
    {
        public UserLoginRequestValidation()
        {
            RuleFor(u => u.Email)
                .NotEmpty();
            RuleFor(u => u.Password)
                .NotEmpty();
        }
    }
}