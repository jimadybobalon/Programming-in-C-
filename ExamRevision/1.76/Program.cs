using System;

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

        static void Main()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d(); // MethodOne, MethodTwo

            Console.Read();
        }
    }
}
