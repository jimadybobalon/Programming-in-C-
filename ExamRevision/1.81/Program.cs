using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._81
{
    class Program
    {
        static void Main()
        {
            Action<int, int> calc = (x, y) =>
                {
                    Console.WriteLine(x + y);
                };

            calc(3, 4);
        }
    }
}
