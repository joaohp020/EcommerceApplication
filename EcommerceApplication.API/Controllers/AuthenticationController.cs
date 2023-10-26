using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.API.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
