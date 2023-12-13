using CleanArchitecture.Domain.Users;
using CleanArchitecture.Domain.Users.Dtos;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories.UserRepositories;

public class UserReadRepository : IUserReadRepository
{
    public Task<UserDto> GetByIdAsync(int userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> GetExistUserByUserNameAndPasswordAsync(string userName, string password, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> GetExistUserByUserNameAsync(string userName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
