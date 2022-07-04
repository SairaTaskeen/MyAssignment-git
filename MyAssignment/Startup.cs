using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MyAssignment.AuthenticationHandler;
using MyAssignment.Log;
using MyAssignment.Models;
using MyAssignment.Repositories;
using MyAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAssignment
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
           
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            ////////////////////////////////////////////////////////////////////////

            //  services.AddControllers(options=>options.Filters.Add(new FilterClass()));
           

            services.AddDbContext<MyDbContext>(); 
            services.AddScoped(typeof(ILogger), typeof(Logger));
            services.AddScoped(typeof(IService<Clinic>), typeof(ClinicServices));
            services.AddScoped(typeof(IService<Person>), typeof(PersonService));
            services.AddScoped(typeof(IService<Staff>), typeof(StaffService));
            services.AddScoped(typeof(IService<Doctor>), typeof(DoctorService));
            services.AddScoped(typeof(IService<DeskStaff>), typeof(DeskStaffService));
            services.AddScoped(typeof(IService<Patient>), typeof(PatientService));
            services.AddScoped(typeof(IService<Visit>), typeof(VisitService));
            services.AddScoped(typeof(IRepository<Clinic>), typeof(ClinicRepository));
            services.AddScoped(typeof(IRepository<Person>), typeof(PersonRepository));
            services.AddScoped(typeof(IRepository<Staff>), typeof(StaffRepository));
            services.AddScoped(typeof(IRepository<Doctor>), typeof(DoctorRepository));
            services.AddScoped(typeof(IRepository<DeskStaff>), typeof(DeskStaffRepository));
            services.AddScoped(typeof(IRepository<Patient>), typeof(PatientRepository));
            services.AddScoped(typeof(IRepository<Visit>), typeof(VisitRepository));

            
            //  services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            //   {

            //});
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAssignment", Version = "v1" });
            });
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
          services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, BasicAuthHandler>("BasicAuthentication", null);
            
        }

        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAssignment v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            ////////
            ///
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
