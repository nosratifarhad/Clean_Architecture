using CleanArchitecture.Application.Features.Authentication.Commands.Login;
using CleanArchitecture.Domain.Users.Dtos;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Authentication.Commands.UserRegister;

namespace CleanArchitecture.Presentation.Controllers;

public class AuthenticationController : BaseController
{
    /// <summary>
    /// Register
    /// </summary>
    /// <param name="userRegisterCommand"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> Register([FromBody] UserRegisterCommand userRegisterCommand,
        CancellationToken cancellationToken)
    {
        return Ok(
            await Mediator.Send(userRegisterCommand, cancellationToken)
            .ConfigureAwait(false));
    }

    /// <summary>
    /// Login
    /// </summary>
    /// <param name="loginQuery"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<UserDto>> Login([FromBody] LoginCommand loginQuery,
    CancellationToken cancellationToken)
    {
        return Ok(
            await Mediator.Send(loginQuery, cancellationToken)
            .ConfigureAwait(false));
    }
}
