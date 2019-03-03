using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Friction.WebVS.Features.Users
{
    public class UserController : Controller
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await mediator.Send(new List.Query());
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Search(Search.Query query)
        {
            var result = await mediator.Send(query);
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> RecentLogins(RecentLogins.Query query)
        {
            var result = await mediator.Send(query);
            return View(result);
        }
    }
}