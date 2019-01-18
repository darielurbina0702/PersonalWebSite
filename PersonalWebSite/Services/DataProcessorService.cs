using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PersonalWebSite.Models;
using PersonalWebSite.Services.Interfaces;

namespace PersonalWebSite.Services
{
    public class DataProcessorService : IDataProcessorService
    {
        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
           ConfigurationManager.AppSettings["dataPath"].ToString());

        public async Task CopyToFileAsync(ContactRequest contactRequest)
        {
            using (FileStream file = File.Open(path, FileMode.Append, FileAccess.Write))
            using (var writer = new StreamWriter(file))
            {
                var json = JsonConvert.SerializeObject(contactRequest);
                await writer.WriteLineAsync(json);
            }
        }

        public async Task<IEnumerable<ContactRequest>> ReadFromFileAsync()
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