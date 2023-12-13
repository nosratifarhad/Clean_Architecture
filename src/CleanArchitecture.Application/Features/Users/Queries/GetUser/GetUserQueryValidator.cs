using FluentValidation;

namespace OnionArchitecture.Application.Features.Users.Queries.GetUser;

public class GetUserQueryValidator : AbstractValidator<GetUserQuery>
{
    public GetUserQueryValidator()
    {
        RuleFor(u => u.Id)
            .GreaterThan(0)
            .WithMessage("Id must be greater than 0.");
    }
}