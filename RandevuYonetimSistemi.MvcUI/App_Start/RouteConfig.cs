using System.Web.Mvc;
using System.Web.Routing;

namespace RandevuYonetimSistemi.MvcUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); // adres çubuğunda sayfalara özel url yapısı(
                                            // /iletisim gibi) oluşturmak için bu kodu ekliyoruz.
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
