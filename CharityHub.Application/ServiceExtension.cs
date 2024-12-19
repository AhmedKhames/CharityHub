using CharityHub.Application.ServiceAbsctractions;
using CharityHub.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CharityHub.Application;

public static class ServiceExtension
{
    public static void ConfigureApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
    }
}