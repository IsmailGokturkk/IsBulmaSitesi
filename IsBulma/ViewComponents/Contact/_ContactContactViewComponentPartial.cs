using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Contact
{
    public class _ContactContactViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
