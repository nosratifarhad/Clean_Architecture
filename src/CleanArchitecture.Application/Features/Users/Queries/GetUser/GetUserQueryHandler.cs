using CleanArchitecture.Domain.Users;
using CleanArchitecture.Domain.Users.Dtos;
using MediatR;

namespace OnionArchitecture.Application.Features.Users.Queries.GetUser;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, GetUserDto>
{
    private readonly IUserReadRepository _userReadRepository;

    public GetUserQueryHandler(IUserReadRepository userReadRepository)
        => _userReadRepository = userReadRepository;

    public async Task<GetUserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var result =
            await _userReadRepository.GetByIdAsync(request.Id, cancellationToken)
            .ConfigureAwait(false);

        var getUserDto = CreateUserDto(result);

        return getUserDto;
    }

    private GetUserDto CreateUserDto(UserDto userDto)
    {
        var getUserDto = new GetUserDto()
        {
            Email = userDto.Email,
            Gender = userDto.Gender,
            Id = userDto.Id,
        };

        return getUserDto;
    }
}