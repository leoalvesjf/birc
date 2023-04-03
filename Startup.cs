using BIRC.Models;
using BIRC.Models.Configuration;
using BIRC.Models.Repositories;
using BIRC.Models.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BIRC
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
            services.AddControllersWithViews();
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (environment == "Production")
            {
                // Configurações de produção
                services.AddDbContext<Contexto>(options => options.UseOracle(Configuration.GetConnectionString("WAMPROD")));
            }
            else
            {
                // Configurações de desenvolvimento
                services.AddDbContext<Contexto>(options => options.UseOracle(Configuration.GetConnectionString("WAMDV")));
            }



            services.AddTransient<ISparePartsRepository, SparePartsRepository>();
            services.AddTransient<IChemicalControlRepository, ChemicalControlRepository>();
            services.AddTransient<ILogUpdateRepository, LogUpdateRepository>();
            services.AddTransient<ISpareRepairerRepository, SpareRepairerRepository>();
            services.AddTransient<ISpareOfficeRepository, SpareOfficeRepository>();
            services.AddTransient<IPessoaRepository, PessoaRepository>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute( name: "default", pattern: "{controller=Home}/{action=Index}/{Id?}");
                //defaults: new { controller = "Home", action = "Registro", id = UrlParameter.Optional }



            });
        }
    }
}
