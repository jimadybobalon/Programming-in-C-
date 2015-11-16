using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._60
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        private static int GetValue(bool p)
        {
            if (p)
                return 1;
            else
                return 0;

            return p ? 1 : 0;
        }
    }
}
