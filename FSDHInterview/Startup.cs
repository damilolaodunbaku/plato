using FSDHInterview.Contexts;
using FSDHInterview.Repository;
using FSDHInterview.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FSDHInterview
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

            services.AddDbContext<LoanContext>(options =>
                options.UseInMemoryDatabase("CustomerDB"));

            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Email = "appsupport@fsdhgroup.com",
                        Name = "Application Support",

                    },
                    Version = "1.0",
                    Description = "A set of API'S for FSDH Interview.",
                    Title = "FSDH Interview API"
                });

            });

            services.AddScoped<FSDHRepository>();
            services.AddSingleton<AuthenticationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FSDH Interview API v1");
                c.RoutePrefix = string.Empty;
            });

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
