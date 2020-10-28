using System.Globalization;
using HospitalEntities.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HospitalClient
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
            // Register services here
            services.AddSingleton(typeof(StaffService.IStaffService), new StaffService.StaffServiceClient());
            services.AddSingleton(typeof(StatisticsService.IStatisticsService), new StatisticsService.StatisticsServiceClient());
            services.AddSingleton(typeof(MessageService.IMessageService), new MessageService.MessageServiceClient());
            services.AddSingleton(typeof(LoginService.ILoginService), new LoginService.LoginServiceClient());
            services.AddSingleton(typeof(AppointmentsService.IAppointmentsService), new AppointmentsService.AppointmentsServiceClient());
            services.AddSingleton(typeof(PatientService.IPatientService), new PatientService.PatientServiceClient());
            services.AddSingleton(typeof(UserService.IUserService), new UserService.UserServiceClient());

            services.AddSession();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => options.LoginPath = "/Login");
            services.AddAuthorization(options =>
            {
                options.AddPolicy(nameof(Staff), authBuilder => { authBuilder.RequireRole(nameof(Staff)); });
                options.AddPolicy(nameof(Patient), authBuilder => { authBuilder.RequireRole(nameof(Patient)); });
            });

            services.AddMvc(option => option.EnableEndpointRouting = false).AddRazorRuntimeCompilation();
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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();

            // Register routes here
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "Appointments",
                    template: "{controller=Appointments}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "requests",
                    template: "{controller=Requests}/{action=Index}");
                routes.MapRoute(
                    name: "Patients",
                    template: "{controller=Patients}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "Profile",
                    template: "{controller=Profile}/{action=Index}");
                routes.MapRoute(
                    name: "Admin",
                    template: "{controller=Admin}/{action=Index}");
            });
        }
    }
}
