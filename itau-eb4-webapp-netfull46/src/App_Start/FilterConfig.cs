﻿using System.Web;
using System.Web.Mvc;

namespace itau_eb4_webapp_netfull46
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
