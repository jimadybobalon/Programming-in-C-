using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._59
{
    class Program
    {
        static void Main()
        {
            int? x = null;
            int? z = null;
            int y = x ??
                    z ??
                    -1;
        }
    }
}
