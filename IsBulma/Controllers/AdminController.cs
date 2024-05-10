using Microsoft.AspNetCore.Mvc;

namespace IsBulma.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
