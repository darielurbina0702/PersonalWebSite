using PersonalWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class ContactRequestController : Controller
    {
        public ViewResult GetContactRequests()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactRequest contact)
        {
            if (!ModelState.IsValid)
                return View(contact);
            else
            {
                return RedirectToAction("Index");
            }
        }


    }
}