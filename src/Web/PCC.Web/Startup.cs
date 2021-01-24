using AutoMapperConfiguration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PCC.Data;
using PCC.Data.Models;
using PCC.Services;
using PCC.Services.Models.Parts;
using PCC.Web.Models.Binding;
using System;
using System.Linq;

namespace PCC.Web
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
            services.AddDbContext<PCCDbContext>(options =>
                    options.UseSqlServer(
                        this.Configuration.GetConnectionString("DefaultConnection")));

            services.AddSingleton<ICloudinaryService>(instance => new CloudinaryService(
                this.Configuration["Cloudinary:CloudName"], 
                this.Configuration["Cloudinary:ApiKey"], 
                this.Configuration["Cloudinary:ApiSecret"]));

            services.AddTransient<IPartsService, PartsService>();

            services.AddDefaultIdentity<PCCUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;

                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;

                options.User.RequireUniqueEmail = true;
            }).AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<PCCDbContext>();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            AutoMapperConfig.RegisterMappings(
                typeof(CreatePartBindingModel).Assembly.GetTypes(),
                typeof(PCCUser).Assembly.GetTypes(),
                typeof(PartServiceModel).Assembly.GetTypes());

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

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                using (var dbContext = serviceScope.ServiceProvider.GetRequiredService<PCCDbContext>())
                {
                    dbContext.Database.Migrate();

                    if (dbContext.Roles.Count() == 0)
                    {
                        dbContext.Roles.Add(new IdentityRole
                        {
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        });

                        dbContext.Roles.Add(new IdentityRole
                        {
                            Name = "User",
                            NormalizedName = "USER",
                            ConcurrencyStamp = Guid.NewGuid().ToString()
                        });

                        dbContext.SaveChanges();
                    }
                }
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
