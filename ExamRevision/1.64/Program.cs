using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._64
{
    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for(int index = 0; index < values.Length;index++)
            {
                Console.WriteLine(values[index]);
                Console.Read();
            }
        }
    }
}
