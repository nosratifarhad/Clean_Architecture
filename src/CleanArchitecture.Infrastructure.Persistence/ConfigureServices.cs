using CleanArchitecture.Domain.Users;
using CleanArchitecture.Infrastructure.Persistence.Repositories.UserRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection RegisterPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<IUserWriteRepository, UserWriteRepository>();
        services.AddScoped<IUserReadRepository, UserReadRepository>();


        return services;
    }
}