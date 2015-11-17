﻿using System;

namespace _1._79
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));

            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
    }
}
