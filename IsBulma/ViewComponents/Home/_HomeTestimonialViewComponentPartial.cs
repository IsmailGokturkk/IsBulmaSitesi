using AutoMapper;
using IsBul.BLL.Abstract;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Home
{
    public class _HomeTestimonialViewComponentPartial:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IClientService _clientService;
       
        public _HomeTestimonialViewComponentPartial(IClientService clientService,IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }
        
        public IViewComponentResult Invoke()
        {
            var test = _clientService.GetAll();
            List<ResultClientModel> clientModels = new List<ResultClientModel>();
            
            
            return View(clientModels);
        }
    }
}
