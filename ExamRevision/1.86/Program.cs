using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._86
{
    public class Pub
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, EventArgs.Empty);
        }
        static void Main()
        {
            CreateAndRaise();
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");

            p.OnChange += (sender, e)
                => { throw new Exception(); };

            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");

            p.Raise();
        }
    }
}
