using Microsoft.AspNetCore.Mvc;

namespace IsBulma.Views.Admin
{
    public class _AdminLayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
