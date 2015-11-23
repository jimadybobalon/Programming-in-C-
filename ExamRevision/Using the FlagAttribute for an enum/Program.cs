﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01
{
    class Program
    {

        [Flags]
        enum Days
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40
        }
        

        static void Main(string[] args){
            Days readingDays = Days.Monday | Days.Saturday;

            

            switch (readingDays) {
            case Days.Monday | Days.Tuesday:

                break;
            case Days.Saturday | Days.Sunday:
                Console.WriteLine("Weekend!");
                break;
            }

            Days setAlarmOn = Days.Monday | Days.Tuesday | Days.Sunday;
        }
    }
}
