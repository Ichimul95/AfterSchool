using System.Collections.Generic;
using System.Web.Mvc;
using MyAfterSchool.Helper;
using MyAfterSchool.Models;

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

        public ActionResult Media(MediaViewModel model)
        {
            string relativePath = "Content\\images\\Media\\";
            model.mediaList = ImageHelper.GettAllImagesFromFolder(relativePath);
            return PartialView("_Media", model);
        }

    }
}