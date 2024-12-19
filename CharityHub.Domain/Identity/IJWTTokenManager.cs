using CharityHub.Domain.Entities;

namespace CharityHub.Domain.IIntegrations;

public interface IJWTTokenManager
{
    string GenerateToken(User userAccount);
    string GenerateRefreshToken();
}