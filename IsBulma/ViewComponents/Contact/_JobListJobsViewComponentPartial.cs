using IsBul.BLL.Abstract;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsBulma.ViewComponents.Home
{
    public class _JobListJobsViewComponentPartial : ViewComponent
    {
        private readonly IJobService _jobService;

        public _JobListJobsViewComponentPartial(IJobService jobService)
        {
            _jobService = jobService;
        }
        public IViewComponentResult Invoke()
        {
            List<ResultJobModel> resultJobModels = new List<ResultJobModel>();

            foreach (var item in _jobService.GetAll())
            {
                resultJobModels.Add(new ResultJobModel()
                {
                   
                    Id = item.Id,
                    CompanyName = item.CompanyName,
                    Title = item.Title,
                    Salary = item.Salary,
                    City = item.City,
                    JobNature = item.JobNature,
                    CoverImage = item.CoverImage,
                    DateLine = item.DateLine,

                });
            }

            return View(resultJobModels);

        }
    }
}
