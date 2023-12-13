using CleanArchitecture.Domain.Users;
using MediatR;

namespace OnionArchitecture.Application.Features.Authentication.Queries.Login;

public class AuthenticationQueryHandler : IRequestHandler<LoginQuery, UserDto>
{
    private readonly IUserWriteRepository _userWriteRepository;

    public AuthenticationQueryHandler(IUserWriteRepository userWriteRepository)
         => _userWriteRepository = userWriteRepository;

    public async Task<UserDto> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

