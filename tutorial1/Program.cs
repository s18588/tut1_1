using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tutorial1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://www.pja.edu.pl";
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);

            var content = response.Content;
            
            var regex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

            var matches = regex.Matches(content.ToString());

            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString());
            }

                
        }
    }
}