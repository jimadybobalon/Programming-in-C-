using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;

namespace _1._30
{
    public static class Program
    {
        public static void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(42);
            bag.Add(21);

            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);

            if (bag.TryPeek(out result))
                Console.WriteLine("There is a new item: {0}", result);

            Console.Read();
        }
    }
}