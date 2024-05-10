using Microsoft.AspNetCore.Mvc;

namespace IsBulma.Views.Admin
{
    public class _AdminLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
    }

