using PersonalWebSite.Infrastructure.Repositories.Interfaces;
using PersonalWebSite.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class ContactRequestController : Controller
    {
        private readonly IContactRequestRepository _contactRequestRepository;

        public ContactRequestController(IContactRequestRepository contactRequestRepository)
        {
            _contactRequestRepository = contactRequestRepository;
        }

        public async Task<ViewResult> GetContactRequestsAsync()
        {
            var contactRequests = await _contactRequestRepository.GetContactRequestsAsync();
            return View("GetContactRequests",contactRequests);
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