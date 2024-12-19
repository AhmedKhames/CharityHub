using CharityHub.Domain.IIntegrations;
using CharityHub.Domain.Services;
using CharityHub.Infrastructure.Integrations;
using CharityHub.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CharityHub.Infrastructure;

public static class ServiceExtension
{
    public static void ConfigureInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUsersRepository, UsersRepository>();
        services.AddScoped<IUserSessionsRepository, UserSessionsRepository>();
        services.AddScoped<IJWTTokenManager, JWTTokenManager>();
        services.AddScoped<IAuthProvider, AuthProvider>();

    }
}