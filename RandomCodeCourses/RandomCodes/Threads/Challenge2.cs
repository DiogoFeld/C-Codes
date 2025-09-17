using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    internal class Challenge2
    {
      
            public async void Test()
            {
                string data = await DownloadDataAsync("test.com", "some content");
                Console.WriteLine(data);
            }

            public async Task<string> DownloadDataAsync(string url, string content)
            {
                await Task.Delay(1000); // espera 1 segundo de forma assíncrona
                string result =  $"Content from URL '{url}' is '{content}'";
                return result;
            }

    }
}
