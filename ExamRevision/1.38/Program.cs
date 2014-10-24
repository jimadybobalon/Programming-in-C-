using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._38
{
    class Program
    {
        static void Main()
        {
            object gate = new object();
            bool _lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref _lockTaken);
            }
            finally
            {
                if (_lockTaken)
                    Monitor.Exit(gate);
            }
        }
    }
}
