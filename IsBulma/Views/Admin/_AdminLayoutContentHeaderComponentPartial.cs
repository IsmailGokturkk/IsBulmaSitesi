using Microsoft.AspNetCore.Mvc;

namespace IsBulma.Views.Admin
{
    public class _AdminLayoutContentHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
