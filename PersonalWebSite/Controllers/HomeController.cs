using PersonalWebSite.Models;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Resume()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
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