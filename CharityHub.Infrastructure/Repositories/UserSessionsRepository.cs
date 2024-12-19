using CharityHub.Domain.Entities;
using CharityHub.Domain.Services;

namespace CharityHub.Infrastructure.Repositories;

public class UserSessionsRepository:IUserSessionsRepository
{
    public bool CreateUserSession(User userAccount, string refreshToken)
    {
        throw new NotImplementedException();
    }
}