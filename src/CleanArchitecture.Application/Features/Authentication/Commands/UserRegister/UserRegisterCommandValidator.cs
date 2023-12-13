using FluentValidation;
using OnionArchitecture.Application.Features.Authentication.Commands.UserRegister;

namespace CleanArchitecture.Application.Features.Authentication.Commands.UserRegister;

public class UserRegisterCommandValidator : AbstractValidator<UserRegisterCommand>
{
    public UserRegisterCommandValidator()
    {
        RuleFor(u => u.FirstName)
               .NotEmpty().WithMessage("FirstName is required")
               .MaximumLength(50).WithMessage("FirstName must be less than 50");

        RuleFor(u => u.FirstName)
               .NotEmpty().WithMessage("LastName is required")
               .MaximumLength(50).WithMessage("LastName must be less than 50");

        RuleFor(u => u.Email)
               .NotEmpty().WithMessage("Email is required")
               .MaximumLength(50).WithMessage("Email must be less than 50");

        RuleFor(u => u.UserName)
               .NotEmpty().WithMessage("UserName is required")
               .MaximumLength(50).WithMessage("UserName must be less than 50");

        RuleFor(u => u.Password)
               .NotEmpty().WithMessage("Password is required")
               .MaximumLength(50).WithMessage("Password must be less than 50");

        RuleFor(u => u.Gender)
               .IsInEnum()
               .WithMessage("Gender is required");

    }
}
