using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.API.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
