using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_2_RequestPipeline_MiddleWare.MiddleWare;
using Microsoft.AspNetCore.Builder;

namespace Bai_2_RequestPipeline_MiddleWare.Extenstions
{
    public static class SimpleMiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddlewareExtensions(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SimpleMiddleware>();
        }
    }
}
