using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreEmpty_Pratik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
