using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._65
{
    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int x = 0, y = values.Length - 1;((x <values.Length) && (y >=0));
                x++, y--)
            {
                Console.WriteLine(values[x]);
                Console.WriteLine(values[y]);
            }

            Console.Read();
        }
    }
}
