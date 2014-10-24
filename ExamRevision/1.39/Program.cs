using System;
using System.Threading;

namespace _1._1
{
    public static class Program
    {
        private static int _flag = 0;
        private static int _value = 0;

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }
        public static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }

        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(Thread1));
            Thread t2 = new Thread(new ThreadStart(Thread2));
            t.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
