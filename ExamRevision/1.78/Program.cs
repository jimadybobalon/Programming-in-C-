using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._78
{
    class Program
    {
        void DoSomething(TextWriter tw) { }
        public delegate void ContravarianceDel(StreamWriter tw);

        ContravarianceDel del = DoSomething;

        static void Main()
        {

        }
    }
}
