﻿using System.Web.Mvc;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Default", action = "Index", id = UrlParameter.Optional } // varsayılan olarak hangi controller ve action çalışsın
            );
        }
    }
}