using CharityHub.Domain.Entities;
using CharityHub.Domain.Services;

namespace CharityHub.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    public User GetUserByPhoneNumber(string mobileNumber)
    {
        throw new NotImplementedException();
    }
}