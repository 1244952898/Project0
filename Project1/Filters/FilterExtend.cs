using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Filters
{
    public static class FilterExtend
    {
        public static MvcOptions AddFilters(this MvcOptions setupAction)
        {
            setupAction = new MvcOptions();
            setupAction.Filters.Add(new Test1Filter());
            return setupAction;
        }

    }
}
