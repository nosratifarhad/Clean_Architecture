
using CleanArchitecture.Domain.Users;
using CleanArchitecture.Domain.Users.Entities;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories.UserRepositories;

public class UserWriteRepository : IUserWriteRepository
{
    public Task<int> AddUserAsync(User user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task ChangeUserLoginStateAsync(UserState userState, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
