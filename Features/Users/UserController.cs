using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Friction.WebVS.Features.Users
{
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> List()
        {
            await _mediator.Send(new List.Query());
            return View();
        }
    }
}