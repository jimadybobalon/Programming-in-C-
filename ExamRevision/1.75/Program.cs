using System;

namespace _1._75
{
    // when we want a variable to reference a method
    // a delegate is a type just like a class or struct
    class Program
    {
        public delegate int Calculate(int x, int y);
        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        static void Main()
        {
            // Delegate type that accepts 2 ints and returns an int, should now pass to the Add method.
            // ie when the calc method is called, run the Add method
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // 7

            calc = Multiply;
            Console.WriteLine(calc(3, 4)); // 12

            // **Instead of strongly typed delegates you can you 
            // generic function types Func<T1, T2, Tresult>

            // A Function that accepts an int, int and returns an int, that delegates to an anonymous method
            Func<int, int, int> subtract = delegate (int x, int y)
            {
                return x - y;
            };

            int result = subtract(6, 4);
            Console.WriteLine(result); // 2

            // using anonymous method
            Func<int, int, int> subtractB = (x, y) => x - y;
            Console.WriteLine(subtractB(6, 4)); // 2


            // using anonymous method
            Action<string> print = delegate (string s) { Console.WriteLine("Message is: " + s); };
            print("Hello world");

            // or Action which returns nothing or Predicate which returns a bool
            // using lambda expression
            Action<string> printB = s => Console.WriteLine("Message is: " + s);
            printB("Hello world");

            Console.Read();
        }
    }
}
