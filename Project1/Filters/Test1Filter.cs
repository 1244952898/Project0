using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Filters
{
    public class Test1Filter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            Console.WriteLine("11111111111111111111111OnActionExecuting111111111111111111111111111111111");
            //do.....
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            Console.WriteLine("11111111111111111111111OnActionExecuted111111111111111111111111111111111");
            //do......
        }
    }
}
