using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_6_MVCWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Thêm service MVC vào trong ứng dụng
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });

            //app.UseMvcWithDefaultRoute(); = Cấu hình sẵn cho 1 Configure route mặc định
            app.UseMvcWithDefaultRoute();

            //app.UseMvc dưới đây cũng tương tự như DefaultRoute ở trên
            // app.UseMvc(routes =>
            // {
            //     routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            // });
           
        }
    }
}
