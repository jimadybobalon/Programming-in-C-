using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _2._17
{

    abstract class AbstractClass{
        public virtual int MyMethod() { return 1; }
    }

    class Original : AbstractClass
    {
        public override int MyMethod()
        {
            return 42;
        }
    }
    class Derived : Original
    {
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Original original = new Original();
            Console.WriteLine(original.MyMethod());

            Derived derived = new Derived();
            Console.WriteLine(derived.MyMethod());

            //Declare Original as Derived
            Original polyOriginal = new Derived();
            Console.WriteLine(polyOriginal.MyMethod());



//            var query =
//from l in GetLeads()
//where AddressLine1 != null && City != null && PostalCode != null && Region != null
//select new MailingAddress
//{ l.Name ?? "Our Neighbors", l.AddressLine1, l.AddressLine2,
//l.City,
//l.Region, l.PostalCode };



            Console.Read();
        }
    }
}
