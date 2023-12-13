using MediatR;

namespace OnionArchitecture.Application.Features.Users.Commands.CreateUser;

public record CreateUserCommand : IRequest<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}