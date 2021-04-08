using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Controllers;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Helpers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CarWash.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })

            .AddCookie(options =>
            {
                 options.Cookie.Expiration = TimeSpan.FromDays(1);
                 options.Cookie.MaxAge = TimeSpan.FromDays(1);
                 options.Cookie.Name = "CarWash.Web";
             });

            //services.ConfigureApplicationCookie(options => 
            //{
            //    options.AccessDeniedPath = new PathString("/manage/users/index");
            //});

          
            //services.AddScoped<IAuthorizationHandler, LoggingAuthorizationHandler>();

            //Append AddRoles to add Role services:
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedEmail = true)
                    .AddRoles<IdentityRole>();


            //Require authenticated users ("options.FallBackPolicy" replace with "options.DefaultPolicy")
            //services.AddAuthorization(options =>
            //{
            //    options.DefaultPolicy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //});

           

            //this services convert enums to return string result.
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });

            services.AddDbContext<DefaultDbContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultDbContextMySQL"), m => m.MigrationsAssembly("CarWash.Web")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAuthorizationHandler, AuthorizeAdminRequirementHandler>();
            services.AddScoped<IAuthorizationHandler, AuthorizeContentAdminRequirementHandler>();   
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAuthorization(options =>
            {
                options.AddPolicy("SignedIn", policy => policy.RequireAuthenticatedUser());
                options.AddPolicy("AuthorizeAdmin", policy => policy.RequireRole("Admin", "ContentAdmin", "AuthorizeAdmin", "Administrator"));
                options.AddPolicy("AuthorizeAdmin", policy => policy.Requirements.Add(new AuthorizeAdminRequirement()));
                options.AddPolicy("AuthorizeContentAdmin", policy => policy.Requirements.Add(new AuthorizeContentAdminRequirement()));
            });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(1);
            });

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();
            
            Infrastructures.Domain.Helpers.WebUser.Services = app.ApplicationServices;
            app.UseSignalR(routeses =>
            {
                routeses.MapHub<SignalHub>("/signalHub");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

              
            });
        }
    }
}
