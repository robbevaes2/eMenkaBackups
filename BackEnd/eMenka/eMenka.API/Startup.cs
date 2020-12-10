using AutoMapper;
using eMenka.Data;
using eMenka.Data.IRepositories;
using eMenka.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
namespace eMenka.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(o =>
            {
                o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            services.AddCors(options =>
            {
                options.AddPolicy("MyAllowSpecificOrigins",
                    builder =>
                    {
                        builder.WithOrigins("*");
                        builder.AllowAnyHeader();
                        builder.AllowAnyMethod();
                    });
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
            services.AddScoped<ISerieRepository, SerieRepository>();
            services.AddScoped<IDoorTypeRepository, DoorTypeRepository>();
            services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
            services.AddScoped<IEngineTypeRepository, EngineTypeRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IRecordRepository, RecordRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IFuelCardRepository, FuelCardRepository>();
            services.AddScoped<ICostAllocationRepository, CostAllocationRepository>();
            services.AddScoped<ICorporationRepository, CorporationRepository>();
            services.AddScoped<IDriverRepository, DriverRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IExteriorColorRepository, ExteriorColorRepository>();
            services.AddScoped<IInteriorColorRepository, InteriorColorRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();

            services.AddDbContext<EfenkaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("eMenKa"));
                options.EnableSensitiveDataLogging();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors("MyAllowSpecificOrigins");

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}