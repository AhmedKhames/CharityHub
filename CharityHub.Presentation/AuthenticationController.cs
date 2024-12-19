using CharityHub.Application.Dtos;
using CharityHub.Application.ServiceAbsctractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CharityHub.Presentation;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly ILogger<AuthenticationController> _logger;
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService authenticationService)
    {
        _logger = logger;
        _authenticationService = authenticationService;
    }


    [HttpPost("login")]
    public ActionResult Login([FromBody] LoginRequest loginRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = _authenticationService.Login(loginRequest);
        if (result is null)
        {
            return Unauthorized();
        }

        return Ok(result);
    }
}