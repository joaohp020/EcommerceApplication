using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.API.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
