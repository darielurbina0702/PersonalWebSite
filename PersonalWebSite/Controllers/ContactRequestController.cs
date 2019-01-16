using PersonalWebSite.Models;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class ContactRequestController : Controller
    {
        public ViewResult GetContactRequests()
        {
            return View();
        }

        public ViewResult ContactMe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactMe(ContactRequest contact)
        {
            if (!ModelState.IsValid)
                return View(contact);
            else
            {
                return RedirectToAction("GetContactRequests");
            }
        }


    }
}