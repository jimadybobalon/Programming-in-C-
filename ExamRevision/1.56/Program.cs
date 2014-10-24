using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._56
{
    class Program
    {
        static void Main()
        {
            bool b = false;
            bool c = true;

            if(b)
            {
                Console.WriteLine("b is true");
            }
            else if (c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("b and c are false");
            }
        }
    }
}
