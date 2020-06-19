using System.Threading.Tasks;
using Fennec.Server.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fennec.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController :ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUser loginUser)
        {
            return Ok(await _mediator.Send(loginUser));
        }
    }
}