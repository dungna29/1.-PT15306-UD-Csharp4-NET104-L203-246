using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Bai_1_EmptyWebApp_ASP_POLY
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // CreateHostBuilder(args).Build().Run();
            /*
             * CreateHostBuilder là một phương thức tạo ra 1 cái Host nhận vào args
             * --> Tạo xong trả về 1 đối tượng là IHostBuilder
             * --> Sau đó gọi ra một Helper Class là CreateDefaultBuilder để tạo 1 server Kestrel Webserver
             * --> Sau đó Sử dụng class Startup để lấy ra các cấu hình
             * --> Cuối cùng là Build() và tiến hành Run() ứng dụng
             */
        }

        // --> Hàm dưới đây gọi là Expression-bodied
        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.UseStartup<Startup>();
        //         });

        //--> Triển khai lại tường minh hơn Expression-bodied
        // public static IWebHostBuilder CreateHostBuilder(string[] args)
        // {
        //     // return Host.CreateDefaultBuilder(args)
        //     //      .ConfigureWebHostDefaults(webBuilder =>
        //     //      {
        //     //          webBuilder.UseStartup<Startup>();
        //     //      });
        //
        //     //Trong thực tế:
        //     // WebHostBuilder các bạn có thể chấm ra rất nhiều thứ bên trong nó
        //     var builder = new WebHostBuilder()
        //             .UseKestrel() //Sử dụng server ở đây là Kestrel
        //             .UseStartup<Startup>()//Gọi đến
        //             .UseContentRoot(Directory.GetCurrentDirectory()) //Chỉ ra thư mục bặc định của ứng dụng
        //             .ConfigureAppConfiguration((hostingContext, config) =>
        //                 {
        //                     var env = hostingContext.HostingEnvironment; //Lấy ra tên của môi trường
        //                     config
        //                         .AddJsonFile("appsettings.json", optional: true,
        //                             reloadOnChange: true) //ứng dụng này sẽ nhận file Config nào
        //                         .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true,
        //                             reloadOnChange: true);
        //                     // Optional = true thì cóc tìm thấy hay không thì cũng ko báo lỗi
        //                     // reloadOnChange:true Tự động nhận cấu hình mới khi có thay đổi
        //
        //                     if (env.IsDevelopment())
        //                     {
        //                         var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
        //                         if (appAssembly != null)
        //                         {
        //                             config.AddUserSecrets(appAssembly, optional: true);
        //                         }
        //                     }
        //
        //                     config.AddEnvironmentVariables(); //Lấy thông tin EnvironmentVariables
        //                     if (args != null)
        //                     {
        //                         config.AddCommandLine(
        //                             args); //nếu trong trường args != null thì cũng lấy ra được từ CommandLine
        //                     }
        //                 }
        //             ) //Sau khi cấu hình xong phần app thì cấu hình tiếp đến phần ConfigureLogging tương tự
        //             .ConfigureLogging((hostingContext, logging) =>
        //             {
        //                 logging.AddConfiguration(
        //                     hostingContext.Configuration.GetSection("Logging")); //Mở file appsettings.json sẽ thấy
        //                 logging.AddConsole(); //In ra cửa sổ Console
        //                 logging.AddDebug();
        //             })
        //             .UseIISIntegration()//Chạy ứng dụng trên IIS
        //             .UseDefaultServiceProvider((context, options) =>
        //                 {
        //                     options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
        //                 });
        //
        //     //Sau khi cấu hình xong chúng ta sẽ return
        //     return builder;
        //
        // }

    }
}
