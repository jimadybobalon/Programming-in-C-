using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._26
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = Convert.ToInt32("42");

            value = int.Parse("42");

            if(int.TryParse("42", out value))
                Console.WriteLine("Parsed: {0}", value);

            if (int.TryParse("76g5", out value))
                Console.WriteLine("Parsed: {0}", value);

            if (int.TryParse("3221111", out value))
                Console.WriteLine("Parsed: {0}", value);
            
            if (int.TryParse(int.MaxValue.ToString(), out value))
                Console.WriteLine("Parsed: {0}", value);

            if (int.TryParse(((decimal)int.MaxValue + 1).ToString(), out value))
                Console.WriteLine("Parsed: {0}", value);

            Console.Read();
        }
    }
}
