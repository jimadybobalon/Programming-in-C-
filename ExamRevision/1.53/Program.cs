using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._53
{
    class Program
    {
        static void Main()
        {
            bool b = true;
            if(b)
            {
                Console.WriteLine("Both these lines");
                Console.WriteLine("Will be executed");
                Console.Read();
            }
        }
    }
}
