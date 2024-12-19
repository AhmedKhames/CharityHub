using CharityHub.Domain.Entities;
using CharityHub.Domain.IIntegrations;

namespace CharityHub.Infrastructure.Integrations;

internal class JWTTokenManager : IJWTTokenManager
{
    public string GenerateToken(User userAccount)
    {
        throw new NotImplementedException();
    }

    public string GenerateRefreshToken()
    {
        throw new NotImplementedException();
    }
}