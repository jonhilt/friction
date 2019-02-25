using Microsoft.AspNetCore.Mvc;

namespace Friction.WebVS.Features.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }        
    }
}
