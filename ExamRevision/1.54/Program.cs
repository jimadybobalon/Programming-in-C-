using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._54
{
    class Program
    {
        static void Main()
        {
            bool b = true;
            if(b)
            {
                int r = 42;
                b = false;
            }

            //r is now accessible
            //b is now false
        }
    }
}
