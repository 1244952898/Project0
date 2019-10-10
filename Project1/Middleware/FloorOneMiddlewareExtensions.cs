using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Middleware
{
    public static class FloorOneMiddlewareExtensions
    {
        public static IApplicationBuilder UseFloorOne(this IApplicationBuilder builder)
        {
            Console.WriteLine("Use FloorOneMiddleware");
            return builder.UseMiddleware<FloorOneMiddleware>();
        }
    }
}
