using System;
using System.Text;
using eMenka.Data;
using eMenka.Data.IRepositories;
using eMenka.Data.Repositories;
using eMenka.Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Stage_API;

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
            services.AddControllers();
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
            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    var tokenSettings = new TokenSettings();
                    Configuration.Bind("token", tokenSettings);
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidIssuer = tokenSettings.Issuer,
                        ValidAudience = tokenSettings.Audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSettings.Key))
                    };
                });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();

            services.AddDbContext<EfenkaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("eMenKa"));
                options.EnableSensitiveDataLogging();
            });
            services.AddIdentity<User, Role>(options =>
                {
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                    options.Lockout.MaxFailedAccessAttempts = 3;

                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireUppercase = false;

                    options.User.RequireUniqueEmail = true;
                })
                .AddEntityFrameworkStores<EfenkaContext>()
                .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
