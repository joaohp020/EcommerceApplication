using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
