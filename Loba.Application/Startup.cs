using AutoMapper;
using Loba.Infrastructure.Data.Context;
using Loba.Infrastructure.DependencyInjection;
using Loba.Infrastructure.Mappings;
using Loba.Service.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Loba.Application
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment _webHostEnvironment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            Environment.SetEnvironmentVariable("DB_CONNECTION", "Server=localhost;Port=3306;Database=lobaapi;Uid=root;Pwd=1234");

            services.AddControllers();
            services.AddScoped<Email>();
            services.AddScoped<PdfUtil>();
            services.AddScoped<SendEmailUtil>();


            ConfigureService.ConfigureDependenciesService(services);
            ConfigureRepository.ConfigureDependenciesRepository(services);

            var config = new AutoMapper.MapperConfiguration(x =>
            {
                x.AddProfile(new DtoToModelProfile());
                x.AddProfile(new EntityToDtoProfile());
                x.AddProfile(new ModelToEntityProfile());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1",
                  new OpenApiInfo
                  {
                      Version = "V1",
                      Title = "TCC - LOBA",
                      Description = "Loba é uma secretaria de reuniões, que busca formatar atas.",
                      Contact = new OpenApiContact
                      {
                          Name = "Beatriz Ramos Lourenço",
                          Email = "beatrizlourenco1912@gmail.com"
                      }
                  });

            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "TCC - LOBA");
                x.RoutePrefix = string.Empty;
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseDefaultFiles();
            app.UseStaticFiles();

            using (var service = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = service.ServiceProvider.GetService<MyContext>())
                {
                    context.Database.Migrate();
                }
            }

        }
    }
}
