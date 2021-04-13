using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Bai_2_RequestPipeline_MiddleWare.MiddleWare
{
    //Tạo custom middleware
    public class SimpleMiddleware
    {


        private readonly RequestDelegate _nextDelegate;

        /*
         * Khai báo class chứa các middleware, dùng con trỏ hàm RequestDelegate tham chiếu
         * đến middleware và dùng phương thức Invoke gọi tới một middleware tiếp theo
         */
        public SimpleMiddleware(RequestDelegate next)
        {
            //next Cho phép gọi đến cái Middleware tiếp theo
            //Lấy tham chiếu của Middleware tiếp theo trong Pipeline lưu vào biến local
            _nextDelegate = next;
        }

        public async Task Invoke(HttpContext context)//Phương thức Invoke nhận tham chiếu đến HttpContext
        {
            await context.Response.WriteAsync("<h1> POLY SimpleMiddleware  [USE]! </h1>");
            await _nextDelegate(context);//Nó sẽ gọi đến middleware tiếp theo
            await context.Response.WriteAsync("<h1> Response POLY SimpleMiddleware  [USE]! </h1>");
        }
    }
}
