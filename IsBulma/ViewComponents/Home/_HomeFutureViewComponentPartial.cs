using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Home
{
    public class _HomeFutureViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
