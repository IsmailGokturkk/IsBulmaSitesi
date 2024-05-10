using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Contact
{
    public class _ContactFeatureViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
