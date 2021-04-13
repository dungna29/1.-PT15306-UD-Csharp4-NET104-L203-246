using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;

namespace Bai_7_Controller_Action_Routing
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                //Cách 1
                routes.MapRoute("default", "{controller=GiaoVien}/{action=Index2}/{temp:int?}");

                //Cách 2
                //temp không có dấu ? có nghĩa là bắt buộc và khai báo tường minh hơn
                // routes.MapRoute("default", "{controller=Home}/{action=Index}/{temp}",
                //     new { controllers = "Home", action = "Index" },
                //     new { temp = new IntRouteConstraint() });


                // routes.MapRoute("default",
                //     "polypost/{id:int}", //Phải là số nguyên với tham số truyền vào thì action sẽ được gọi
                //     new { controller = "PolyPost", action = "PostById" });
                // ;
                //
                // routes.MapRoute("anotherRoute",
                //     "polypost/{id:alpha}", //Phải là chữ cái thì action sẽ được gọi
                //     new { controller = "PolyPost", action = "PostByName" });
                // ;
                //
                // routes.MapRoute("defaultRegex",
                //     "polypost/year/{year:regex(^\\d{{4}}$)}", //Giá tị phải là 4 chữ số
                //     new { controller = "PolyPost", action = "RegexPoly" });

                // //Kết hợp nhiều ràng buộc bằng dấu :
                // routes.MapRoute("defaultlength",
                //     "polypost/length/{id:alpha:minlength(6)?}", //Giá trị truyền vào phải là chữ và có độ dài 6 ký tự
                //     new { controller = "PolyPost", action = "CombingConstraints" });
                //
                // routes.MapRoute("defaultlength", "{controller=PolyPost}/{action=CombingConstraints}/{id:alpha:minlength(6)?}");
                //
                // //Tương tự trên cách viết tương minh hơn
                // routes.MapRoute("defaultlength",
                //     "{controller}/{action}/{id}",//Giá trị truyền vào phải là chữ và có độ dài 6 ký tự
                //     new { controller = "PolyPost", action = "CombingConstraints" },
                //     constraints: new
                //     {
                //         id = new CompositeRouteConstraint(
                //             new IRouteConstraint[] {
                //                     new AlphaRouteConstraint(),
                //                     new MinLengthRouteConstraint(6)
                //             })
                //     });







            });
            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("FPOLY Cannot Find Route");
            });
        }
    }
}
