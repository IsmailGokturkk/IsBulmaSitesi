using AutoMapper;
using IsBul.BLL.Abstract;
using IsBul.BLL.DTOs.JobDTO;
using IsBul.Entitty;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Home
{
    public class _HomeJobsViewComponentPartial:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IJobService _jobService;

        public _HomeJobsViewComponentPartial(IJobService jobService, IMapper mapper)
        {
            _mapper = mapper;
            _jobService = jobService;
        }
        public IViewComponentResult Invoke()
        {
            var jobs = _jobService.GetAll();

            List<ResultJobDTO> resultJobDTO = _mapper.Map<List<ResultJobDTO>>(jobs);

            return View(resultJobDTO);
        
        }
    }
}
