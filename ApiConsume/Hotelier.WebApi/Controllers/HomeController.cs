using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
