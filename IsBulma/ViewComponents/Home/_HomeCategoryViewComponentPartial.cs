using IsBul.BLL.Abstract;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Home
{
    public class _HomeCategoryViewComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _HomeCategoryViewComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            List<ResultJobTypeModel> resultJobTypeModels = new List<ResultJobTypeModel>();

            foreach (var item in _categoryService.GetAll())
            {
                if (item.Status)
                {
                    resultJobTypeModels.Add(new ResultJobTypeModel()
                    {

                        Name = item.Name,
                        Status = item.Status,
                        Icon = item.Icon,
                        Jobs = item.Jobs
                    });
                }
            }

            return View(resultJobTypeModels);
        }
    }
}

