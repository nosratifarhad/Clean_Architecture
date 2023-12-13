using CleanArchitecture.Domain.Users.Entities;

namespace CleanArchitecture.Domain.Users;

public interface IUserWriteRepository
{

    Task<int> AddUserAsync(User user, CancellationToken cancellationToken);

    Task ChangeUserLoginStateAsync(UserState userState, CancellationToken cancellationToken);

}
