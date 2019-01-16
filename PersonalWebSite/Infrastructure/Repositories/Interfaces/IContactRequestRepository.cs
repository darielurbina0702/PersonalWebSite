using PersonalWebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalWebSite.Infrastructure.Repositories.Interfaces
{
    public interface IContactRequestRepository
    {
        Task<IEnumerable<ContactRequest>> GetContactRequestsAsync();

        Task<ContactRequest> AddContactRequest(ContactRequest contactRequest);
        
    }
}
