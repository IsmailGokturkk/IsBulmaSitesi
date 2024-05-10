using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Contact
{
    public class _JobDetailStartViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}