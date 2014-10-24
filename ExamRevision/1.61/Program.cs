using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._61
{
    class Program
    {
        static void Main()
        {
            string input;
            input = Console.ReadKey().ToString();
            Console.WriteLine();
            if(input == "a"
                || input == "e"
                || input == "i"
                || input == "o"
                || input =="u")
            {
                Console.WriteLine("Input is a vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
            Console.Read();
        }
    }
}
