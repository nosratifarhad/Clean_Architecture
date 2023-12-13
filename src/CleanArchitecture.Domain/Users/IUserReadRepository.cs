using CleanArchitecture.Domain.Users.Dtos;

namespace CleanArchitecture.Domain.Users;

public interface IUserReadRepository
{
    Task<UserDto> GetByIdAsync(int userId);

}