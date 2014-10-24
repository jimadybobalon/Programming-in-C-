using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._63
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        break;
                    }
            }
        }
    }
}
