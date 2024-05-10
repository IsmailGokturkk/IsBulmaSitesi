using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Home
{
    public class _HomeSearchComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           return View();
        }
    }
}
