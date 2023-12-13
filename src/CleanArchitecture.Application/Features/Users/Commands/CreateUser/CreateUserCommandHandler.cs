using CleanArchitecture.Domain.Users;
using CleanArchitecture.Domain.Users.Entities;
using MediatR;

namespace OnionArchitecture.Application.Features.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IUserWriteRepository _userWriteRepository;

    public CreateUserCommandHandler(IUserWriteRepository userWriteRepository)
        => _userWriteRepository = userWriteRepository;

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = CreateUser(request);

        var userId = await _userWriteRepository.AddUserAsync(user, cancellationToken).ConfigureAwait(false);

        return userId;
    }

    private User CreateUser(CreateUserCommand command)
    {
        var user = new User
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email
        };

        return user;
    }
}