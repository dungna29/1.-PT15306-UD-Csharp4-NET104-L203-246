using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_1_EmptyWebApp_ASP_POLY
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            /*
             * ConfigureServices: để định cấu hình các dịch vụ của ứng dụng . Dịch vụ là một thành phần có thể sử dụng lại cung cấp chức năng ứng dụng.
             */
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*
             * 	-IApplicationBuilder app: Dùng để cấu hình request pipeline
			 *  -IWebHostEnvironment env: Dùng để chỉ ra môi trường đang hoạt động là môi trường nào
             */

            if (env.IsDevelopment())// --> Môi trường hiện tại là  IsDevelopment
            {
                app.UseDeveloperExceptionPage();// --> Sẽ  hiển thị lỗi chi tiết của ứng dụng về code
                //Đây có thể nói là một MiddleWare đã dựng sẵn
            }

            app.UseRouting();

            //Dưới đây cũng là một MiddleWare có Response trả về và ghi ra 1 dòng chữ Hello World!
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
