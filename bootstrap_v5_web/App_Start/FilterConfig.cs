﻿using System.Web;
using System.Web.Mvc;

namespace bootstrap_v5_web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
