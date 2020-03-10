using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tutorial1
{
    class Program
    {
        [STAThread]
        static void Main()
        {
        }
        static async Task Main(string[] args)
        {
            const string URL = @"http://www.pja.edu.pl/";
            Console.WriteLine("hi");
            
            
            var httpclient = new HttpClient();
            var response = await httpclient.GetAsync(URL);
            var regex = new Regex("[a-z]+[a-z0-9]*@[a-z]+\\.[a-z]+", RegexOptions.IgnoreCase);
            var responseContent = await response.Content.ReadAsStringAsync();
            var matches = regex.Matches(responseContent);

            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString());
            }

                
        }
    }
}