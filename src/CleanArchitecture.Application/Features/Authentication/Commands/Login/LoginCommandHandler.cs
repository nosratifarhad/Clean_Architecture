using CleanArchitecture.Domain.Users;
using CleanArchitecture.Domain.Users.Dtos;
using CleanArchitecture.Domain.Users.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Application.Features.Authentication.Commands.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
{
    private readonly IUserWriteRepository _userWriteRepository;
    private readonly IUserReadRepository _userReadRepository;

    public LoginCommandHandler(IUserWriteRepository userWriteRepository,
        IUserReadRepository userReadRepository)
    {
        _userWriteRepository = userWriteRepository;
        _userReadRepository = userReadRepository;
    }

    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var userDto = await GetExistUserByUserNameAndPasswordAsync(request, cancellationToken).ConfigureAwait(false);

        var userState = CreateUserState(userDto);

        await _userWriteRepository.ChangeUserLoginStateAsync(userState, cancellationToken).ConfigureAwait(false);

        var token = await GetToken(userDto).ConfigureAwait(false);

        return token;
    }

    #region [ Private ]

    private async Task<UserDto> GetExistUserByUserNameAndPasswordAsync(LoginCommand request, CancellationToken cancellationToken)
    {
        var userDto =
                await _userReadRepository.GetExistUserByUserNameAndPasswordAsync(request.UserName, request.Password, cancellationToken)
                .ConfigureAwait(false);

        if (userDto == null)
            throw new ValidationException("UserName Is Not Exist.");

        return userDto;
    }

    private async Task<string> GetToken(UserDto userDto)
    {
        return await Task.Run(() => "eyJhbSflKxwRJSMeK.adQssw5cMeJf36POk6yJV.KF2QT4fwp");
    }

    private UserState CreateUserState(UserDto userDto)
    {
        var userState = new UserState()
        {
            UserId = userDto.Id,
            guid = Guid.NewGuid(),
            IsLogin = true,
            LoginDate = DateTime.Now,
            LogOutDate = null,
        };

        return userState;
    }

    #endregion [ Private ]

}

