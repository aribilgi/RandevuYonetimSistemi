using System.Web.Mvc;

namespace RandevuYonetimSistemi.MvcUI.Areas.Admin.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}