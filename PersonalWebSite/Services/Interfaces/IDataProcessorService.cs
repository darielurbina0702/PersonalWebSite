using PersonalWebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalWebSite.Services.Interfaces
{
    public interface IDataProcessorService
    {
        Task CopyToFileAsync(ContactRequest contactRequest);

        Task<IEnumerable<ContactRequest>> ReadFromFileAsync();
    }
}
