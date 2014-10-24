using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._75
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        public static void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); //DIsplays 7

            calc = Multiply;
            Console.WriteLine(calc(3, 4)); //Displays 12

            Console.Read();
        }
        static void Main()
        {
            UseDelegate();
        }
    }
}
