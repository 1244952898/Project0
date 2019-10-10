using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Middleware
{
    public class FloorOneMiddleware
    {
        private readonly RequestDelegate _next;
        public FloorOneMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("FloorOneMiddleware In");
            await _next(context);
            Console.WriteLine("FloorOneMiddleware Out");
        }
    }
}
