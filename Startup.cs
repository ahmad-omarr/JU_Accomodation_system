using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Models;
using SystemWebDorms.Models.Repositories;

namespace SystemWebDorms
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
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddScoped<InterfaceSystemWebDorms<MasterDorm>, MasterDormRepository>();
            services.AddScoped<InterfaceSystemWebDorms<MasterMenu>, MasterMenuRepository>();
            services.AddScoped<InterfaceSystemWebDorms<MasterSlider>, MasterSliderRepository>();
            services.AddScoped<InterfaceSystemWebDorms<MasterSocialMedium>, MasterSocialMediumRepository>();
            services.AddScoped<InterfaceSystemWebDorms<SystemSetting>, SystemSettingRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransContactUs>, TransContactUsRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransInnerDormDoubleRoom>, TransInnerDormDoubleRoomRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransInnerDormNight>, TransInnerDormNightRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransInnerDormTripleRoom>, TransInnerDormTripleRoomRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransInternationalDormDoubleRoom>, TransInternationalDormDoubleRoomRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransInternationalDormDoubleRoomSister>, TransInternationalDormDoubleRoomSisterRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransInternationalDormNightRoom>, TransInternationalDormNightRoomRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransInternationalDormSingleRoom>, TransInternationalDormSingleRoomRepository>();
            services.AddScoped<InterfaceSystemWebDorms<TransInternationalDormTripleRoom>, TransInternationalDormTripleRoomRepository>();

            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(Configuration.GetConnectionString("SqlCon"));

            });

            services.AddDistributedMemoryCache();
            services.AddSession();


            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.ConfigureApplicationCookie(options =>
            {
                //options here

                options.LoginPath = "/Admin/Account/Login";

                //...
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
                endpoints.MapControllerRoute(
                    name: "areas",
                                      //pattern: "{area:exists}/{controller=MasterDorm}/{action=index}/{id?}"
                    pattern: "{area:exists}/{controller=Account}/{action=Login}/{id?}"

            );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
