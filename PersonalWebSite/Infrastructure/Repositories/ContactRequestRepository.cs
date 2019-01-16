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

        public async Task<IEnumerable<ContactRequest>> GetContactRequestsAsync()
        {
            return new List<ContactRequest>()
            {
                new ContactRequest
                {
                    Name = "Peter",
                    Email = "peter@gmail.com",
                    Subject = "Question",
                    Message = "Can you help me with my homework"
                },

                new ContactRequest
                {
                    Name = "Chris",
                    Email = "chris@gmail.com",
                    Subject = "Recruiter",
                    Message = "Are you interested in any position"
                }
            };
        }
    }
}