﻿using System.Reflection;
using AutoMapper;
using DataAccess;
using DataAccess.Interface;
using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.AutoMapperConfiguration;
using Service.Interface;
using Service.Services;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Reservation
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
            services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapperConfiguration)));
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Reservation", Version = "v1" });
            });
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            var connection = Configuration.GetConnectionString("context");
            services.AddDbContext<Context>(options => options.UseSqlServer(connection));
            services.AddScoped<DbContext, Context>();
            services.AddTransient<IBranchRepository, BranchRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IBranchService,BranchService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IEmployRepository, EmployRepository>();
            services.AddTransient<IEmployService, EmployeeService>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Reservation V1");
                c.DocExpansion(DocExpansion.None);
            });
 
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
