using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._76
{
    class Program
    {
        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public static void mulitcast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();

            Console.Read();
        }
        static void Main()
        {
            mulitcast();
        }
    }
}
