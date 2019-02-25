using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Friction.WebVS.Features.Users
{
    public class UserController : Controller
    {        
        public async Task<IActionResult> List()
        {
            return View();
        }
    }
}