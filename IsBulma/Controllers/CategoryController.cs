using IsBul.BLL.Abstract;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsBulma.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var models = new List<CategoryModel > ();

            foreach(var item in _categoryService.GetAll())
            {
                models.Add(new CategoryModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Status = item.Status,
                    Icon = item.Icon,

                });
            }
            return View(models);
        }
        public IActionResult Create()
        {
            return View(new CategoryModel());
        }

        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            return View(model);  
        }
    }
}
