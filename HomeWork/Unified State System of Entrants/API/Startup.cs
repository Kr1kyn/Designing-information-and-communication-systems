using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Unified_State_System_of_Entrants.BLL.Services;
using Unified_State_System_of_Entrants.DAL.ContextDB;
using Unified_State_System_of_Entrants.DAL.Interfaces;
using Unified_State_System_of_Entrants.DAL.Repositories;

namespace API
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IRepositoryEntrant, RepositoryEntrant>();
            services.AddScoped<IRepositoryHEI, RepositoryHEI>();
            services.AddScoped<IRepositoryUser, RepositoryUser>();
            services.AddScoped<IRepositoryRankedListApplicants, RepositoryRankedListApplicants>();
            services.AddScoped<ServiceUser>();
            services.AddScoped<ServiceHEI>();
            services.AddScoped<ServiceEntrant>();
            services.AddScoped<ServiceRankedListApplicants>();

            //services.AddScoped<Unified_State_System_of_Entrants.BLL.Services.ServiceRankedListApplicants>();
            services.AddDbContext<UsedDbContext>((options) =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API for HW");
                c.RoutePrefix = string.Empty;
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
