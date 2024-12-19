using CharityHub.Domain.Entities;

namespace CharityHub.Domain.Services;

public interface IUsersRepository
{
    User GetUserByPhoneNumber(string mobileNumber);
}