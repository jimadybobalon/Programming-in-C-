using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace _1._32
{
    public static class Program
    {
        public static void Main()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);

            int result;
            if (stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);

            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (int i in values)
                Console.WriteLine(i);

            Console.Read();
        }
    }
}
