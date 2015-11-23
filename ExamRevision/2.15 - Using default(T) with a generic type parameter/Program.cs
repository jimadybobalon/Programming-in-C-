using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15
{
    class Program
    {
        public static void MyGenericMethod<T>()
        {
            T defaultValue = default(T);
            Console.WriteLine("\"" + defaultValue + "\"");
        }

        static void Main(string[] args)
        {

            MyGenericMethod<string>();
            MyGenericMethod<int>();
            MyGenericMethod<float>();
            MyGenericMethod<char>();

            Console.Read();
        }
    }
}
