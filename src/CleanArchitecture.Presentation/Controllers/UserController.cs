using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Users.Commands.CreateUser;
using OnionArchitecture.Application.Features.Users.Queries.GetUser;

namespace CleanArchitecture.Presentation.Controllers
{
    public class UserController : BaseController
    {
        /// <summary>
        /// Get User
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUser([FromQuery] GetUserQuery query, CancellationToken cancellationToken)
        {
            return Ok(
                await Mediator.Send(query, cancellationToken)
                .ConfigureAwait(false));
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand command, CancellationToken cancellationToken)
        {
            return Ok(
                await Mediator.Send(command, cancellationToken)
                .ConfigureAwait(false));
        }
    }
}
