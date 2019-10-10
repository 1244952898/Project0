using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Project1.Route
{
    public class MyRouteHandler
    {
        public static async Task Handler(HttpContext context)
        {
            await context.Response.WriteAsync("MyRouteHandler");
        }
    }
}
