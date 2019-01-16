using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalWebSite.Infrastructure.Repositories.Interfaces;
using PersonalWebSite.Models;

namespace PersonalWebSite.Infrastructure.Repositories
{
    public class ContactRequestRepository : IContactRequestRepository
    {
        public Task<ContactRequest> AddContactRequest(ContactRequest contactRequest)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ContactRequest>> GetContactRequestsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}