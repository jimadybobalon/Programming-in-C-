using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._48
{
    public class Program
    {
        public static void Main()
        {
            OrShortCircuit();
        }
        public static void OrShortCircuit()
        {
            bool x = true;
            bool result = x || GetY();
        }

        public static bool GetY()
        {
            Console.WriteLine("This method doesn't get called");
            return true;
        }
    }
}