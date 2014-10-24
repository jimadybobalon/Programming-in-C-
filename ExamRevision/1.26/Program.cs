using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._22
{
    public static class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0);

            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}
