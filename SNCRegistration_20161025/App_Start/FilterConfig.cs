﻿using System.Web;
using System.Web.Mvc;

namespace SNCRegistration_20161025
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
