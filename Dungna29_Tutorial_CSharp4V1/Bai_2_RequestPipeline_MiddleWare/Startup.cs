using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_2_RequestPipeline_MiddleWare.Extenstions;
using Bai_2_RequestPipeline_MiddleWare.MiddleWare;

namespace Bai_2_RequestPipeline_MiddleWare
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /*
         * CẤU HÌNH MiddleWare trong phương thúc Configure
         */
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())//Nếu đang sử dụng môi trường Develop
            {
                app.UseDeveloperExceptionPage();//Thì khi lỗi nó sẽ hiển thị ra trang chi tiết lỗi
            }

            // app.UseRouting();
            //
            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapGet("/", async context =>//context bao gồm các thông tin về URL...
            //     {
            //         await context.Response.WriteAsync("C#4 FPOLY DUNGNA29");
            //     });
            // });

            //Xây dựng Middleware Use
            // Middleware Use có 1 thằng next có thể pass tiếp request cho Middleware sau
            // Nếu không sử dụng next nó cũng sẽ không chạy tiếp
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<h1> POLY Middleware 1 [USE]! </h1>");
                await next.Invoke();//Nó sẽ gọi đến middleware tiếp theo và phải sử dụng câu lệnh này

                //Sau khi có Invoke thì đến khi nó quay lại sẽ can thiệp tiếp lần thứ 2
                await context.Response.WriteAsync("<h1> Response POLY Middleware 1 [USE]! </h1>");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<h1> POLY Middleware 2 [USE] </h1>");
                await next.Invoke();//Nó sẽ gọi đến middleware tiếp theo và phải sử dụng câu lệnh này

                //Sau khi có Invoke thì đến khi nó quay lại sẽ can thiệp tiếp lần thứ 2
                await context.Response.WriteAsync("<h1> Response POLY Middleware 2 [USE]! </h1>");
            });

            //**********Gọi đến Simple Middleware và đặt sau thằng Middleware 2
            //app.UseMiddleware<SimpleMiddleware>();//Cách 1
            app.UseMiddlewareExtensions();//Cách 2

            //Xây dựng Middleware Run
            //Run là middleware cuối nó sẽ không thể chạy tiếp ra Middleware phía sau của nó vì nó nằm ở cuối Request Pipeline
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1> POLY Middleware 3 [Run] </h1>");//WriteAsync là ghi ra bất đồng bộ
            });
            /*
             * Và nhớ rằng sau khi xử lý 1 Request thì sẽ có thể trả về lại phía client vì vậy
             * với mỗi Middleware sẽ có 2 cơ hội để có thể tác động vào reqest
             */
        }
    }
}
