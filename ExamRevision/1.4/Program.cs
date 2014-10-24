using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1._4
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main()
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>
                {
                    while (!stopped)
                    {
                        Console.WriteLine("Running...");
                        Thread.Sleep(1000);
                    }
                }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }

    }
}
