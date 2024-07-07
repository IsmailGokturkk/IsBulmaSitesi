using IsBul.BLL.Abstract;
using IsBul.BLL.Concrete;
using IsBul.DAL.Abstract;
using IsBul.DAL.Concrete.EfCore;
using IsBulma.Mapping;

namespace IsBulma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddAutoMapper(typeof(MappingProfile));

                    
            
            builder.Services.AddScoped<ICategoryService, CategoryManager>();
            builder.Services.AddScoped<ICategoryDal,EfCoreCategoryDal>();

            builder.Services.AddScoped<IJobService, JobManager>();
            builder.Services.AddScoped<IJobDal, EfCoreJobDal>();

            builder.Services.AddScoped<IWhoWeAreService,WhoWeAreManager>();
            builder.Services.AddScoped<IWhoWeAreDal,EfCoreWhoWeAreDal>();

            builder.Services.AddScoped<IEmploymentService, EmploymentManager>();
            builder.Services.AddScoped<IEmploymentDal, EfCoreEmploymentDal>();

            builder.Services.AddScoped<IClientService, ClientManager>();
            builder.Services.AddScoped<IClientDal, EfCoreClientDal>();

            builder.Services.AddScoped<IContactService, ContactManager>();
            builder.Services.AddScoped<IContactDal, EfCoreContactDal>();

            builder.Services.AddScoped<IJobDetailService,JobDetailManager>();
            builder.Services.AddScoped<IJobDetailDal,EfCoreJobDetailDal>();

            builder.Services.AddScoped< ICompanyDetailService,CompanyDetailManager>();
            builder.Services.AddScoped<ICompanyDetailDal, EfCoreCompanyDetails>();




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Admin}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
