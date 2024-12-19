using CharityHub.Application.Dtos;
using CharityHub.Application.ServiceAbsctractions;
using CharityHub.Domain.IIntegrations;
using CharityHub.Domain.Services;
using Microsoft.Extensions.Logging;

namespace CharityHub.Application.Services;

public class AuthenticationService:IAuthenticationService
{
    private readonly IUsersRepository _usersRepository;
    private readonly IAuthProvider _authProvider;
    private readonly ILogger<AuthenticationService> _logger;
    private readonly IJWTTokenManager _jwtTokenManager;
    private readonly IUserSessionsRepository _userSessionsRepository;

     public AuthenticationService(IUsersRepository usersRepository, IAuthProvider authProvider,
        ILogger<AuthenticationService> logger, IJWTTokenManager jwtTokenManager,
        IUserSessionsRepository userSessionsRepository)
    {
        _usersRepository = usersRepository;
        _authProvider = authProvider;
        _logger = logger;
        _jwtTokenManager = jwtTokenManager;
        _userSessionsRepository = userSessionsRepository;
    }
    
    public LoginResponse Login(LoginRequest request)
    {
        try
        {
            var mobileNumber = _authProvider.GetVerifiedPhoneNumber(request.IdToken);

            var userAccount = _usersRepository.GetUserByPhoneNumber(mobileNumber);
            if (userAccount is null)
            {
                _logger.LogWarning("The user with id token {IdToken} could not be found", request.IdToken);
                return null;
            }

            var accessToken = _jwtTokenManager.GenerateToken(userAccount);
            var refreshToken = _jwtTokenManager.GenerateRefreshToken();
            var isSessionSaved = _userSessionsRepository.CreateUserSession(userAccount, refreshToken);
            return !isSessionSaved ? null : new LoginResponse(accessToken, refreshToken);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Unexpected error happened with message {Message}", e.Message);
            return null;
        }
    }
}