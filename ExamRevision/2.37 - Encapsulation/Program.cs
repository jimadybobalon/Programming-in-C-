using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._37
{
    class Program
    {

        class Person{
            private string _firstName;
            public string FirstName
            {
                get { return _firstName; }
                set{
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException();
                    _firstName = value;
                }
            }
        }

        static void Main(string[] args){

            Person person = new Person();

            person.FirstName = "Name";

            person.FirstName = "";

            person.FirstName = null;
            
        }
    }
}
