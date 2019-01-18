using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalWebSite.Infrastructure.Repositories.Interfaces;
using PersonalWebSite.Models;
using PersonalWebSite.Services.Interfaces;

namespace PersonalWebSite.Infrastructure.Repositories
{
    public class ContactRequestRepository : IContactRequestRepository
    {      

        private readonly IDataProcessorService _dataProcessorService;

        public ContactRequestRepository(IDataProcessorService dataProcessorService)
        {
            _dataProcessorService = dataProcessorService;
        }        

        public async Task AddContactRequestAsync(ContactRequest contactRequest)
        {
            await _dataProcessorService.CopyToFileAsync(contactRequest);
        }

        public async Task<IEnumerable<ContactRequest>> GetContactRequestsAsync()
        {
            return await _dataProcessorService.ReadFromFileAsync();
        }
    }
}