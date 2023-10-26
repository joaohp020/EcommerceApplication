using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.API.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
