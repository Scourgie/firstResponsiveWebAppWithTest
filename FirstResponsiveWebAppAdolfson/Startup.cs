using FirstResponsiveWebAppAdolfson.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace FirstResponsiveWebAppAdolfson
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StudentContext>(options => options.UseSqlServer(Configuration.GetConnectionString("StudentContext")));

            services.AddControllersWithViews(); 
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting(); // mark where routing decisions are made

            app.UseAuthorization();

            // configure middleware that runs after routing decisions have been made

            app.UseEndpoints(endpoints => // map the endpoints 
            {
                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "paging_and_sorting",
                    pattern: "{controller}/{action}/{id}/page{page}/sort-by-{sortby}");

                endpoints.MapControllerRoute(
                    name: "paging",
                    pattern: "{controller}/{action}/{id}/page{page}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }

    }
}
