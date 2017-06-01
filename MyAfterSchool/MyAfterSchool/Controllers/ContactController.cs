using System;
using System.Web.Mvc;
using MyAfterSchool.Models;
using MyAfterSchool.Services;

namespace MyAfterSchool.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmailService service = new EmailService();
                    service.SendContact(model.Name, model.Subject, model.Email, model.Phone, model.Message);
                    return View("Index");
                }
                return View("Index", model);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
