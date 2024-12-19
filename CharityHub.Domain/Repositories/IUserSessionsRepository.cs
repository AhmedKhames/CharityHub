using CharityHub.Domain.Entities;

namespace CharityHub.Domain.Services;

public interface IUserSessionsRepository
{
    bool CreateUserSession(User userAccount, string refreshToken);
}