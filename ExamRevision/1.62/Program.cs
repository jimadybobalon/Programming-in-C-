using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._62
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadKey().ToString();

            switch (input)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    {
                        Console.WriteLine("Input is a vowel");
                    }
                    break;
                case "y":
                    {
                        Console.WriteLine("Input is sometimes a vowel");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input is a consonant");
                        break;
                    }
            }
        }
    }
}
