using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Layout
{
    public class _SpinnerViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
