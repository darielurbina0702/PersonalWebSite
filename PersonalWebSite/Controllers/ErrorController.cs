using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ViewResult NotFoundError()
        {           
            ViewBag.Error = "404 Not Found";
            ViewBag.ErrorType = "Requested page not found!"; 
            return View("HttpErrors");
        }

        public ViewResult ServerError()
        {
            ViewBag.Error = "500 Server Error";
            ViewBag.ErrorType = "Internal Server Error!";
            return View("HttpErrors");            
        }
    }
}