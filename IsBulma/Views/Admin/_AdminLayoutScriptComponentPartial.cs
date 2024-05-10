using Microsoft.AspNetCore.Mvc;

namespace IsBulma.Views.Admin
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
