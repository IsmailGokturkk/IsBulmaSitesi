using IsBul.BLL.Abstract;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IsBulma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View(_categoryService.GetAll);
        }
       

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult JobList()
        {
            return View();
        }
        public IActionResult JobDetail()
        {
            return View();
        }

    }
}
