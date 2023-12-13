using CleanArchitecture.Domain.Users.Enums;
using MediatR;

namespace OnionArchitecture.Application.Features.Authentication.Commands.UserRegister;

public record UserRegisterCommand : IRequest<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Gender Gender { get; set; }
}