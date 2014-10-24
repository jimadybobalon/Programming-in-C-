using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _1._93
{
    class Program
    {
        static void Main()
        {
            try
            {
                string i = Console.ReadLine();
                OpenAndParse(i);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("StackTrace: {0}", e.StackTrace);
                Console.WriteLine("HelpLink: {0}", e.HelpLink);
                Console.WriteLine("InnerException: {0}", e.InnerException);
                Console.WriteLine("TargetSite: {0}", e.TargetSite);
                Console.WriteLine("Source: {0}", e.Source);
            }
            Console.Read();
        }

        private static string OpenAndParse(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
                throw new ArgumentNullException("filename", "filename is required");
            return File.ReadAllText(filename);
        }
    }
}
