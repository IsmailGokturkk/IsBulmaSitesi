using AutoMapper;
using AutoMapper.Configuration.Annotations;
using IsBul.BLL.Abstract;
using IsBul.BLL.DTOs.CategoryDTO;
using IsBul.BLL.DTOs.JobDTO;
using IsBul.Entitty;
using IsBulma.Mapping;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emlakci.WEBUI.Controllers
{
    public class JobController : Controller
    {
        private readonly IJobService _jobService;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly ICompanyDetailService _companyDetailService;


        public JobController(IJobService jobService, ICategoryService categoryService, ICompanyDetailService companyDetailService, IMapper mapper)
        {
            _jobService = jobService;
            _categoryService = categoryService;
            _companyDetailService = companyDetailService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var jobs = _jobService.GetAll();
            List<ResultJobDTO> models = _mapper.Map<List<ResultJobDTO>>(jobs);
            return View(models);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _categoryService.GetAll();
            ViewBag.CompanyDetails = _companyDetailService.GetAll();

            return View(new CreateJobDTO());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateJobDTO model, IFormFile file)
        {
            ModelState.Remove("CoverImage");
            ModelState.Remove("file");
            ModelState.Remove("CompanyDetail");
            ModelState.Remove("Category");


            if (ModelState.IsValid)
            {
                if (file == null)
                {
                    ModelState.AddModelError("", "Resim zorunludur.");

                    ViewBag.Categories = _categoryService.GetAll();
                    ViewBag.CompanyDetails = _companyDetailService.GetAll();
                    return View(model);
                }
                //var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\RealEstate\\img", file.FileName);

                //using (var stream = new FileStream(path, FileMode.Create))
                //{
                //    await file.CopyToAsync(stream);
                //    model.CoverImage = file.FileName;
                //}
                model.CoverImage = await ImageMethod.UploadImage(file);
                _jobService.Create(_mapper.Map<Job>(model));
                return RedirectToAction("Index");
            }


            ViewBag.Categories = _categoryService.GetAll();
            ViewBag.CompanyDetails = _companyDetailService.GetAll();
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Title = "Not Found",
                    Message = "Aradığınız bulunamadı",
                    ReturnUrl = "/Job/Index"
                };

                return View("Error",error);
            }
            var job = _jobService.GetById(id);

            if (job == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Title = "Bulunamadı",
                    Message = "Bulunan ilan yaz",
                    ReturnUrl = "/Job/Index"
                };
            }

            var model = _mapper.Map<UpdateJobDTO>(job);

            ViewBag.Categories = _categoryService.GetAll();
            ViewBag.CompanyDetails = _companyDetailService.GetAll();

            //return View(new UpdateJobDTO())
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<IActionResult> Edit(UpdateJobDTO model,IFormFile file)
        {
            ModelState.Remove("CoverImage");
            ModelState.Remove("file");
            ModelState.Remove("CompanyDetail");
            ModelState.Remove("Category");
            ModelState.Remove("CompanyName");
            
            if (ModelState.IsValid)
            {
                var job = _jobService.GetById(model.Id);

                if (file != null)
                {
                    ImageMethod.DeleteImage(job.CoverImage);

                    model.CoverImage = await ImageMethod.UploadImage(file);
                }

                _jobService.Update(_mapper.Map<Job>(model));

                return RedirectToAction("Index");
            }


            
            ViewBag.Categories = _categoryService.GetAll();
            ViewBag.CompanyDetails = _companyDetailService.GetAll();
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            if (id < 1)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel()
                {
                    Title = "Bad request",
                    Message = "Id gönderilmedi",
                    ReturnUrl = "/Job/Index"
                };

                return View("Error", errorViewModel);

            }
            var job = _jobService.GetById(id);

            if (job == null)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel()
                {
                    Title = "Not Found",
                    Message = "İlan bulunamadı",
                    ReturnUrl = "/Job/Index"
                };
                return View("Error", errorViewModel);
            }

            _jobService.Delete(job);
            ImageMethod.DeleteImage(job.CoverImage);

            return RedirectToAction("Index");
        }


      


    }
}