using PersonalWebSite.Infrastructure.Repositories.Interfaces;
using PersonalWebSite.Models;
using System;
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
            return View("GetContactRequests", contactRequests);
        }

        public ViewResult ContactMe()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ContactMeAsync(ContactRequest contact)
        {
            if (!ModelState.IsValid)
                return View("ContactMe", contact);
            else
            {
                try
                {
                   contact.Date = DateTime.Now;
                   await _contactRequestRepository.AddContactRequestAsync(contact);
                }

                catch(Exception e) {
                    return View("ContactMe", contact);
                }
                
                return RedirectToAction("GetContactRequestsAsync");
            }
        }
    }
}