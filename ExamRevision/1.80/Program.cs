using System;

namespace _1._79
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main()
        {
            Calculate calc = (x, y) =>
                    {
                        Console.WriteLine("adding numbers");
                        return x + y;
                    };
            int result = calc(3, 4);
        }
    }
}
