using CleanArchitecture.Domain.Users.Dtos;

namespace CleanArchitecture.Domain.Users;

public interface IUserReadRepository
{
    Task<bool> GetExistUserByUserNameAsync(string userName, CancellationToken cancellationToken);

    Task<UserDto> GetExistUserByUserNameAndPasswordAsync(string userName, string password, CancellationToken cancellationToken);

    Task<UserDto> GetByIdAsync(int userId, CancellationToken cancellationToken);

}