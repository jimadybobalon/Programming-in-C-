using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._51
{
    class Program
    {
        static void Main()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a ^ a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ b);
            Console.Read();
        }
    }
}
