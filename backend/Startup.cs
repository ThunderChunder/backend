using Datalayer.InsuranceForm;
using Datalayer.PageContent;
using DomainLayer.InsuranceForm;
using DomainLayer.InsuranceForm.Interfaces;
using DomainLayer.PageContent;
using DomainLayer.PageContent.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TALbackend
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
            services.AddCors();
            services.AddControllers();
            services.AddScoped<IPageContentService, PageContentService>();
            services.AddScoped<IPageContentRepository, PageContentRepository>();
            services.AddScoped<IPageContentDao, PageContentDao>();
            services.AddScoped<IInsuranceFormService, InsuranceFormService>();
            services.AddScoped<IInsuranceFormRepository, InsuranceFormRepository>();
            services.AddScoped<IInsuranceFormDao, InsuranceFormDao>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(
                options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
                );

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
