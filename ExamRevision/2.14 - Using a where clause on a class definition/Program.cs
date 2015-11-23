using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._14
{
    class Program
    {

        //Declared with new(), so the type must have a public default constructor. 
        class MyClass<T> where T : class, new()
        {
            public MyClass()
            {
                MyProperty = new T();
            }
            T MyProperty { get; set; }
        }

        class TestClass1 {
            
        }

        class TestClass2
        {
            public TestClass2()
            {

            }
        }

        class TestClass3
        {
            public TestClass3(string message)
            {

            }
        }

        static void Main(string[] args)
        {

            MyClass<TestClass1> newClass1 = new MyClass<TestClass1>();


            MyClass<TestClass2> newClass2 = new MyClass<TestClass2>();

            //Broken, because TestClass3 does not contain a public constructor
            //MyClass<TestClass3> newClass3 = new MyClass<TestClass3>();

        }
    }
}
