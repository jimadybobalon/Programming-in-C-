using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._82
{
    public class Pub
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
            Console.Read();
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }

        public static void Main()
        {
            CreateAndRaise();
        }
    }
}
