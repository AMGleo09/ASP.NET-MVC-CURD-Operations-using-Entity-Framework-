﻿using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Machine_Test_Nimap
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
