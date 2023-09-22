﻿using FluentValidation;
using NotificationService.Models.QueryParameters.Create;

namespace NotificationService.Models.Validation.QueryParametersValidation
{
    public class PushRequestQuerryParametersValidation : AbstractValidator<PushRequestQuerryParameters>
    {
        public PushRequestQuerryParametersValidation()
        {
            RuleFor(e => e.UserId)
                .NotEmpty();
        }
    }
}