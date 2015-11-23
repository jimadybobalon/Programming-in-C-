using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._07
{
    class Program
    {

        static void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {

        }

        static void OtherMethod(
            int number = 1,
            string secondArgument = "default value",
            bool thirdArgument = false,
            bool fourthArgument = true
        )
        {

        }

        static void Main(string[] args)
        {
            //Overrides the second optional argument, without having to pass the first
            MyMethod(1, thirdArgument: true);
            
            //Other examples
            OtherMethod();

            OtherMethod(number: 0, fourthArgument: false);

            OtherMethod(fourthArgument: true, secondArgument: "Dance", number: 2);
            
        }
    }
}
