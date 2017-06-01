using System.Web.Mvc;

namespace MyAfterSchool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Benefits()
        {
            return PartialView("_Benefits");
        }

        public ActionResult Media()
        {
            return PartialView("_Media");
        }

    }
}