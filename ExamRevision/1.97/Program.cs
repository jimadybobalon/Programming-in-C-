using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _1._97
{
    class Program
    {
        static void Main()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if(possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}
