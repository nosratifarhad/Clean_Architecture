using MediatR;

namespace CleanArchitecture.Application.Features.Authentication.Commands.Login;

public class LoginCommand : IRequest<string>
{
    public string UserName { get; set; }
    public string Password { get; set; }
}