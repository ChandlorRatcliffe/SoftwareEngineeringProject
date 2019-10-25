using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NimbleWeb.Models;

namespace NimbleWeb
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSingleton<IAccountRepository, AccountRepository>();
            services.AddSingleton<IAutomationRepository, AutomationRepository>();
            services.AddSingleton<IBugRepository, BugRepository>();
            services.AddSingleton<IHomeRepository, HomeRepository>();
            services.AddSingleton<ILinksRepository, LinksRepository>();
            services.AddSingleton<IReportsRepository, ReportsRepository>();
            services.AddSingleton<ISearchRepository, SearchRepository>();
            services.AddSingleton<ISqlScriptsRepository, SqlScriptsRepository>();
            services.AddSingleton<ITestRunnerRepository, TestRunnerRepository>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else if (env.IsStaging() || env.IsEnvironment("Testing") || env.IsProduction())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //app.UseCors();

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                });
            });

        }
    }
}
