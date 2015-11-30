using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._42___Interface_Extras
{
    class Program
    {

        interface IGetValue {
            int value { get; }
        }

        interface ISetValue{
            int value { set; }
        }

        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////

        struct GetStruct : IGetValue
        {
            public int value { get; }
        }

        //class SetStruct : ISetValue{              //Broken, as it does not have a get
        //    public int value { set; }
        //}
        
        struct GetSetStruct : IGetValue, ISetValue
        {
            public int value { get; set; }
        }

        class SetStruct : ISetValue {               //Manually adding a get
            public int value { get; set; }
        }

        class GetSetStruct2 : IGetValue{            //Manually adding a set
            public int value { get; set; }
        }

        static void Main(string[] args)
        {


        }
    }
}
