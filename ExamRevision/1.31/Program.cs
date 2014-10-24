using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _1._31
{
    public static class Program
    {
        public static void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });
            Task.Run(() =>
            {
                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();

            Console.Read();
        }
    }
}