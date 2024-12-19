using CharityHub.Application.Dtos;

namespace CharityHub.Application.ServiceAbsctractions;

public interface IAuthenticationService
{
    LoginResponse Login(LoginRequest request);
}