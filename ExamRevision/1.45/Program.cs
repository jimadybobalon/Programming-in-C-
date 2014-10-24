using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._43
{
    public class Program
    {
        static void Main()
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(1000);
            });

            int index = Task.WaitAny(new[] { longRunning }, 1000);

            if (index == -1)
                Console.WriteLine("Task timed out");
        }
    }
}
