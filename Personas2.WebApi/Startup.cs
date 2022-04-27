using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personas2.Data.Context;
using Personas2.Service.Interface;
using Personas2.Service.Implementation;
using AutoMapper;
using Personas2.Data.Mapping;

namespace Personas2.WebApi
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
            services.AddTransient<IPersona2Service, Persona2Service>();
            services.AddTransient<IEnumsService, EnumsService>();
            services.AddAutoMapper(typeof(Mapeos));
            services.AddCors(x => { x.AddPolicy("Personas2.CORS", y => y.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()); });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Personas2.WebApi", Version = "v1" });
            });

            services.AddDbContext<Personas2Context>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ConexionDB")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Personas2.WebApi v1"));
            }

            app.UseCors("Personas2.CORS");
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
