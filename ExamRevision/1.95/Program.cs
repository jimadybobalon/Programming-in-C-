using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._95
{
    class Program
    {
        static void Main()
        {
            try
            {
                string s = Console.ReadLine();
                int i = int.Parse(s);
            }
            catch (Exception LogEx)
            {
                Console.WriteLine(LogEx);
                throw;
            }
        }
    }
}
