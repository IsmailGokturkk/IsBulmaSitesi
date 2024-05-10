using Microsoft.AspNetCore.Mvc;

namespace IsBulma.Views.Admin
{
    public class _AdminLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
