using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12
{
    class Program
    {

        class ConstructorChaining
        {
            private int _p;
            public ConstructorChaining() : this(3) { }
            public ConstructorChaining(int p) : this("Constructor")
            {
                this._p = p;
            }

            public ConstructorChaining(string message)
            {
                Console.WriteLine(message);
            }
        }

        static void Main(string[] args)
        {



        }
    }
}
