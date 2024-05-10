using IsBul.BLL.Abstract;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IsBulma.ViewComponents.Home
{
    public class _HomeAboutViewComponentPartial:ViewComponent
    {
    private readonly IEmploymentService _employmentService;
    private readonly IWhoWeAreService _whoWeAreService;

        public _HomeAboutViewComponentPartial(IEmploymentService employmentService, IWhoWeAreService whoWeAreService)
        {
            _employmentService = employmentService;
            _whoWeAreService = whoWeAreService;

        }
        public IViewComponentResult Invoke()
        {
           var whoWeAre=_whoWeAreService.GetAll().FirstOrDefault();

            ViewBag.Title = whoWeAre.Title;
            ViewBag.Description = whoWeAre.Description;

            return View( _employmentService.GetAll().Where(i => i.Status == true).Select(i => new ResultEmploymentModel()
            {
                Name = i.Name,
                Status = i.Status,
                Id = i.Id,
            }).ToList());
        }
    }
}
