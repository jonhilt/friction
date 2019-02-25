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

        public async Task<IActionResult> List()
        {
            var list = await mediator.Send(new List.Query());
            return View(list);
        }

        public async Task<IActionResult> Search(Search.Query query)
        {
            var results = await mediator.Send(query);
            return View(results);
        }
    }
}