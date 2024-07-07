using AutoMapper;
using IsBul.BLL.Abstract;
using IsBul.BLL.DTOs.CompanyDetailDTO;
using IsBul.Entitty;
using IsBulma.Mapping;
using IsBulma.Models;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom;

namespace IsBulma.Controllers
{
    public class CompanyDetailController : Controller
    {
        

        private readonly ICompanyDetailService _companyDetailService;
        private readonly IMapper _mapper;

        public CompanyDetailController(ICompanyDetailService companyDetailService, IMapper mapper)
        {
            _companyDetailService = companyDetailService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var companydetails = _companyDetailService.GetAll();

            return View(_mapper.Map<List<ResultCompanyDetailDTO>>(companydetails));
        }
        public IActionResult Create()
        {

            return View(new CreateCompanyDetailDTO());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCompanyDetailDTO model,IFormFile file)
        {
            ModelState.Remove("file");
            if(ModelState.IsValid)
            {
                var cd=_companyDetailService.GetAll(i=>i.Title==model.Title).FirstOrDefault();

                if(cd!=null)
                {
                    ModelState.AddModelError("", "Aynı isimle şirket kayıtlı");
                    return View(model);

                }


                var companydetail = _mapper.Map<CompanyDetail>(model);
                _companyDetailService.Create(companydetail);
                return RedirectToAction("Index");
            }   
            

            return View( model);
        }

        public IActionResult Edit(int id)
        {
            var model =_companyDetailService.GetById(id);

            if(model == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Title = "Not Found",
                    Message = "Aradığınız bulunamadı",
                    ReturnUrl = "/CompanyDetail/Index"
                };

                return View("Error",error);
            }

            var companyDetailModel = _mapper.Map<UpdateCompanyDetailDTO>(model);



            return View(companyDetailModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateCompanyDetailDTO model)
        {
           
            if (ModelState.IsValid)
            {
                var companyDetail = _mapper.Map<CompanyDetail>(model);

                _companyDetailService.Update(companyDetail);

                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var companyDetail = _companyDetailService.GetById(id);

            _companyDetailService.Delete(companyDetail);
            return RedirectToAction("Index");
        }
    }
}
