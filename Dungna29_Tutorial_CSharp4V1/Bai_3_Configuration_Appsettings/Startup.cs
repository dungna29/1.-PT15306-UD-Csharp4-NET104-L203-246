using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Bai_3_Configuration_Appsettings
{
    public class Startup
    {
        /*
         * Trong Startup.cs tạo một thể hiện từ interface Iconfiguration để đọc nội dung từ appsettings.json
         */
        private readonly IConfiguration _iConfiguration;//Khai báo 1 biến

        // Khởi tạo 1 contructor trong Startup
        public Startup(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseRouting();
            /*
             * Bên trong phương thức Configure truy xuất đến key:fpoly và dùng
             * context.Response.WriteAsync hiển thị nội dung
             */

            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync(_iConfiguration.GetSection("dungna29").Value);
                //Các bạn sẽ in ra được các thông tin bên phí appsetting dựa vào key
                //Để đọc được đến các thằng con chỉ cần dùng dấu : giữa Key

                //Đọc mảng từ file cấu hình
                await context.Response.WriteAsync(_iConfiguration.GetSection("PolyStudent:0:Msv").Value + "  ");
                await context.Response.WriteAsync(_iConfiguration.GetSection("PolyStudent:0:Age").Value);

            });
        }
    }
}
