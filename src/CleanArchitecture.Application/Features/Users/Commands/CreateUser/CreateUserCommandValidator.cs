using FluentValidation;

namespace OnionArchitecture.Application.Features.Users.Commands.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(u => u.FirstName)
               .NotEmpty().WithMessage("FirstName is required")
               .MaximumLength(50).WithMessage("first name must be less than 50");

        RuleFor(u => u.LastName)
               .NotEmpty().WithMessage("LastName is required")
               .MaximumLength(50).WithMessage("last name must be less than 50");
    }
}