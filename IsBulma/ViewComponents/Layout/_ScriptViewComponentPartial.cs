using Microsoft.AspNetCore.Mvc;
namespace IsBulma.ViewComponents.Layout
{
    public class _ScriptViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
