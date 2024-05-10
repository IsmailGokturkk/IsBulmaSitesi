using IsBul.BLL.Abstract;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Home
{
    public class _HomeTestimonialViewComponentPartial:ViewComponent
    {
        private readonly IClientService _clientService;
       
        public _HomeTestimonialViewComponentPartial(IClientService clientService)
        {
            _clientService = clientService;
        }
        
        public IViewComponentResult Invoke()
        {
            List<ResultClientModel> clientModels = new List<ResultClientModel>();
            foreach(var item in _clientService.GetAll())
            {
                clientModels.Add(new ResultClientModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Profession = item.Profession,
                    Comment = item.Comment,
                    ImageUrl = item.ImageUrl,
                });
            }
            return View(clientModels);
        }
    }
}
