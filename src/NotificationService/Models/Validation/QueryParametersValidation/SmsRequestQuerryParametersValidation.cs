﻿#region

using FluentValidation;
using NotificationService.Models.QueryParameters.Create;

#endregion

namespace NotificationService.Models.Validation.QueryParametersValidation;

public class SmsRequestQuerryParametersValidation : AbstractValidator<CreateSmsRequestQueryParameters>
{
    public SmsRequestQuerryParametersValidation()
    {
        RuleFor(e => e.UserId)
            .NotEmpty();
    }
}