﻿using System.Web;
using System.Web.Mvc;

namespace DotNetFramework._4._7._2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
