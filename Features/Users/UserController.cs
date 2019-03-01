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
            var result = await _mediator.Send(new List.Query());
            return View(result);
        }

        public async Task<IActionResult> Search(Search.Query query)
        {
            var result = await _mediator.Send(query);
            return View(result);
        }
    }
}