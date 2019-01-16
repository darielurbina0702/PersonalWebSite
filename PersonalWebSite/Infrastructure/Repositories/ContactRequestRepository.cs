using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using PersonalWebSite.Infrastructure.Repositories.Interfaces;
using PersonalWebSite.Models;

namespace PersonalWebSite.Infrastructure.Repositories
{
    public class ContactRequestRepository : IContactRequestRepository
    {
        private const string path = @"C:/Users/Dariel.Urbina/source/repos/PersonalWebSite/PersonalWebSite/Data/data.txt";

        public async Task AddContactRequestAsync(ContactRequest contactRequest)
        {
            using (FileStream file = File.Open(path, FileMode.Append, FileAccess.Write))
            using (var writer = new StreamWriter(file))
            {              
                var json = JsonConvert.SerializeObject(contactRequest);
                await writer.WriteLineAsync(json);
            }
        }

        public async Task<IEnumerable<ContactRequest>> GetContactRequestsAsync()
        {
            List<ContactRequest> result = new List<ContactRequest>();
            using (var reader = new StreamReader(path))
            {               
                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();
                    if (line != string.Empty)
                    {
                        var request = JsonConvert.DeserializeObject<ContactRequest>(line);
                        result.Add(request);                        
                    }                    
                }

                return result;
            }           
        }
    }
}