using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Layout
{
    public class _NavbarViewComponentPartial : ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
