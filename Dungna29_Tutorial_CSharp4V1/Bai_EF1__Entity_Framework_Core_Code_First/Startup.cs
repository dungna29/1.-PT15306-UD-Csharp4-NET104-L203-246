using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_EF1__Entity_Framework_Core_Code_First.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Bai_EF1__Entity_Framework_Core_Code_First
{
    public class Startup
    {/*
         * 1. Khởi tạo Migrations
         *              add-migration MigrationsDungna29
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
        
        public void ConfigureServices(IServiceCollection services)
        {
            //Khai báo chuỗi kết nối (có thể ghi ở appsettings.json)
            services.AddDbContext<DatabaseContext>(c => c.UseSqlServer(Configuration.GetConnectionString("DungnaDB1AspCoreSql")));//Cấu hình đường dẫn cho DBcontext
            services.AddMvc();
        }

      
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Categories}/{action=Create}/{id?}");
            });
            //
            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Dungna29 Cannot Find Route");
            // });
        }
    }
}
