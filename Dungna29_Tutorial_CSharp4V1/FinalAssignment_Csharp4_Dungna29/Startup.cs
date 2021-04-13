using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalAssignment_Csharp4_Dungna29.Context;
using FinalAssignment_Csharp4_Dungna29.IServices;
using FinalAssignment_Csharp4_Dungna29.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FinalAssignment_Csharp4_Dungna29
{
    public class Startup
    {
        /*
         * 1. Khởi tạo Migrations
         *              add-migration MigrationsFinalAssignmentDungna29
         * 2. Tiến hành cập nhật đối tượng tạo thành bảo vào DB
         *              update-database
         *
         */

        #region Khai báo để trong ConfigureServices có thể gọi được
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        #endregion

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddDbContext<DatabaseContext>(c => c.UseSqlServer(Configuration.GetConnectionString("FinalAssignmentAspCoreSql")));//Cấu hình đường dẫn cho DBcontext
            services.AddMvc();
            //services.AddScoped<IProductServices, ProductServices>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Dungna29 Cannot Find Route");
            });
        }
    }
}
