using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._50
{
    class Program
    {
        public static void Main()
        {
            string input = null;
            Process(input);
        }

        static void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
            Console.WriteLine(result);
        }
    }
}
