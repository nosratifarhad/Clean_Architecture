using CleanArchitecture.Domain.Users.Enums;

namespace CleanArchitecture.Domain.Users.Dtos;

public class UserDto
{
    public Guid Id { get; set; }
    public Gender Gender { get; set; }
    public string Email { get; set; }
}
