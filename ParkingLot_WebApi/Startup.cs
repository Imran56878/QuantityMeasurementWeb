using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using ParkingLotRepository;
using ParkingLotRepository.Context;
using ParkingLotRepository.Police;
using ParkingManager;
using ParkingManager.Police;

namespace ParkingLot_WebApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContextPool<UserDBContext>(Options => Options.UseSqlServer(Configuration.GetConnectionString("UserDbConnection")));
            services.AddTransient<IParkingManager,ImpParkingManager>();
            services.AddTransient<IPoliceManager, ImpPoliceManager>();
            services.AddTransient<IRepository,ImpRepository>();
            services.AddTransient<IPoliceRepo, ImpPoliceRepo>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())  
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c=>{ c.SwaggerEndpoint("/swagger/v1/swagger.json", "myapi v1");  });
            }
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}                            
