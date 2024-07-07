using AutoMapper;
using IsBul.BLL.DTOs.CategoryDTO;
using IsBul.BLL.DTOs.CompanyDetailDTO;
using IsBul.BLL.DTOs.JobDTO;
using IsBul.BLL.DTOs.TestimonialDTO;
using IsBul.Entitty;

namespace IsBulma.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, ResultCategoryDTO>().ReverseMap();
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category,UpdateCategoryDTO>().ReverseMap();
            CreateMap<Job,ResultJobDTO>().ReverseMap();
            CreateMap<Job,CreateJobDTO>().ReverseMap();
            CreateMap <Client,ResultTestimonialDTO>().ReverseMap();
            CreateMap<Job,UpdateJobDTO>().ReverseMap();
            CreateMap<CompanyDetail,ResultCompanyDetailDTO>().ReverseMap();
            CreateMap<CompanyDetail,CreateCompanyDetailDTO>().ReverseMap();
            CreateMap<CompanyDetail,UpdateCompanyDetailDTO>().ReverseMap();



        }

    }
}
