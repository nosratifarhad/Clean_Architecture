using MediatR;

namespace OnionArchitecture.Application.Features.Users.Queries.GetUser;

public record GetUserQuery : IRequest<GetUserDto>
{
    public int Id { get; set; }
}