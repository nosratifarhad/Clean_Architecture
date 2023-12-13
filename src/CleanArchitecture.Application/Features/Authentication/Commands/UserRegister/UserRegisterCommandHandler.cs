using CleanArchitecture.Domain.Users;
using CleanArchitecture.Domain.Users.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace OnionArchitecture.Application.Features.Authentication.Commands.UserRegister;

public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommand, int>
{
    private readonly IUserWriteRepository _userWriteRepository;
    private readonly IUserReadRepository _userReadRepository;

    public UserRegisterCommandHandler(IUserWriteRepository userWriteRepository,
        IUserReadRepository userReadRepository)
    {
        _userWriteRepository = userWriteRepository;
        _userReadRepository = userReadRepository;
    }

    public async Task<int> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
    {
        await GetExistUserByUserNameAsync(request.UserName, cancellationToken).ConfigureAwait(false);

        var user = CreateUser(request);

        var userId = await _userWriteRepository.AddUserAsync(user, cancellationToken);

        return userId;
    }

    #region [ Private ]

    private async Task GetExistUserByUserNameAsync(string userName, CancellationToken cancellationToken)
    {
        var isExistUserName =
                await _userReadRepository.GetExistUserByUserNameAsync(userName, cancellationToken)
                .ConfigureAwait(false);

        if (!isExistUserName)
            throw new ValidationException("UserName Is Already Exist.");
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

    #endregion [ Private ]

}