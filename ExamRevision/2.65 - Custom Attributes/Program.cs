using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._65___Custom_Attributes
{
    [DeveloperAttribute("Jordan O'Hare", "1")]
    class Program
    {

        [AttributeUsage(AttributeTargets.All)]
        public class DeveloperAttribute : Attribute
        {
            // Private fields.
            public string name;
            private string level;
            private bool reviewed;

            // This constructor defines two required parameters: name and level.

            public DeveloperAttribute(string name, string level)
            {
                this.name = name;
                this.level = level;
                this.reviewed = false;
            }

            // Define Name property.
            // This is a read-only attribute.

            public virtual string Name
            {
                get { return name; }
            }

            // Define Level property.
            // This is a read-only attribute.

            public virtual string Level
            {
                get { return level; }
            }

            // Define Reviewed property.
            // This is a read/write attribute.

            public virtual bool Reviewed
            {
                get { return reviewed; }
                set { reviewed = value; }
            }
        }
        
        public static void Test(){

        }

        public static void GetAttribute(Type t){
            // Get instance of the attribute.
            DeveloperAttribute MyAttribute = 
                (DeveloperAttribute)Attribute.GetCustomAttribute(t, typeof(DeveloperAttribute));

            if (MyAttribute == null){
                Console.WriteLine("The attribute was not found.");
            }else{
                // Get the Name value.
                Console.WriteLine("The Name Attribute is: {0}.", MyAttribute.Name);
                // Get the Level value.
                Console.WriteLine("The Level Attribute is: {0}.", MyAttribute.Level);
                // Get the Reviewed value.
                Console.WriteLine("The Reviewed Attribute is: {0}.", MyAttribute.Reviewed);
            }
        }

        static void Main(string[] args){

            GetAttribute(typeof(Program));

            Console.Read();
        }
    }
}
