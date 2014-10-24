using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._74
{
    class Program
    {
        static void Main()
        {
            int x = 3;
            if (x == 3) goto customlabel;
            x++;

            customlabel:
            Console.WriteLine(x);
            Console.Read();

        }
    }
}
