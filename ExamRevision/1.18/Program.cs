using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _1._18
{
    public static class Program
    {
        public static void Main()
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
            Console.Read();
        }

        public static async Task<string> DownloadContent()
        {
            using(HttpClient Client = new HttpClient())
            {
                string result = await Client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
