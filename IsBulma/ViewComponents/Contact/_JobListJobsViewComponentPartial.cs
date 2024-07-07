using AutoMapper;
using IsBul.BLL.Abstract;
using IsBul.BLL.DTOs.JobDTO;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Home
{
    public class _JobListJobsViewComponentPartial : ViewComponent
    {
        private readonly IJobService _jobService;
        private readonly IMapper _mapper;

        public _JobListJobsViewComponentPartial(IJobService jobService,IMapper mapper)
        {
            _jobService = jobService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var jobs = _jobService.GetAll;
            List<ResultJobDTO> ResultJobDTO = _mapper.Map<List<ResultJobDTO>>(jobs);

          

            return View(ResultJobDTO);

        }
    }
}
