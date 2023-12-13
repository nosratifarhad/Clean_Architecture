using CleanArchitecture.Domain.Users.Enums;

namespace OnionArchitecture.Application.Features.Users.Queries.GetUser;

public class GetUserDto
{
    public Guid Id { get; set; }
    public Gender Gender { get; set; }
    public string Email { get; set; }
}