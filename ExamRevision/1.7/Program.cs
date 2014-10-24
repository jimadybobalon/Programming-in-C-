using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1._7
{
    public static class Program
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
                {
                    Console.WriteLine("Working on a thread from threadpool");
                });

            Console.ReadLine();
        }
    }
}