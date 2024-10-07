
using Ecommerce.Application.Automapper;
using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.Contracts.Services;
using Ecommerce.Application.Repository;
using Ecommerce.Infrastructure.Presistance;
using Ecommerce.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBContextApplication>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductServicecs, ProductServicecs>();
            services.AddScoped<IProductRopository, ProductRopository>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IProductServicecs, ProductServicecs>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IVisaService, VisaService>();
            services.AddScoped<IVisaRepository, VisaRepository>();





            services.AddAutoMapper(typeof(CategoryProfile).Assembly);
            services.AddAutoMapper(typeof(ProdactProfile).Assembly);
            services.AddAutoMapper(typeof(AddressProfile).Assembly);
            services.AddAutoMapper(typeof(BrandProfile).Assembly);
            services.AddAutoMapper(typeof(ReviewProfile).Assembly);
            services.AddAutoMapper(typeof(visaProfile).Assembly);


            //services.AddAutoMapper(typeof(Program));       
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }



        public static WebApplication UseAPIServices(this WebApplication app)
        {


            return app;
        }
    }
}
