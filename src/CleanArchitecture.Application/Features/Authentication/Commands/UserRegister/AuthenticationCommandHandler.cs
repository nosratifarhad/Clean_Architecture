using CleanArchitecture.Domain.Users;
using CleanArchitecture.Domain.Users.Entities;
using MediatR;

namespace OnionArchitecture.Application.Features.Authentication.Commands.UserRegister;

public class AuthenticationCommandHandler : IRequestHandler<UserRegisterCommand, int>
{
    private readonly IUserWriteRepository _userWriteRepository;

    public AuthenticationCommandHandler(IUserWriteRepository userWriteRepository)
         => _userWriteRepository = userWriteRepository;

    public async Task<int> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
    {
        var user = CreateUser(request);

        var userId = await _userWriteRepository.AddUserAsync(user, cancellationToken);

        return userId;
    }

    private User CreateUser(UserRegisterCommand command)
    {
        var user = new User
        {
            Email = command.Email,
            Password = command.Password,
            FirstName = command.FirstName,
            LastName = command.LastName,
            Gender = command.Gender,
            UserName = command.UserName
        };

        return user;
    }
}