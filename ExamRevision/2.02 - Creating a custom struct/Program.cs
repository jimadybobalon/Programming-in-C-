using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._02
{
    class Program
    {

        public struct Point
        {
            public int x, y;

            //public Point()       //Incorrect. You cannot declare a parameterless constructor for a struct
            //{

            //}

            public Point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
