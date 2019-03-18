using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Jil;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            using (var handler = new HttpClientHandler())
            {
                handler.ServerCertificateCustomValidationCallback
                    = (message, cert, chain, errors) => { return true; };
                using (var client = new HttpClient(handler))
                {
                    CallApi(client);
                }
            }
        }

        private static void CallApi(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "DotNet Hello World Cmd");
            
            var t = client.GetStringAsync("https://localhost:5001/api/greetings/");
            var result = t.GetAwaiter().GetResult();
            var json = JSON.Deserialize<Greeting>(result);
            Console.WriteLine(json.message);
        }
    }

    internal class Greeting
    {
        public string name { get; set; }
        public string message { get; set; }
    }
}
