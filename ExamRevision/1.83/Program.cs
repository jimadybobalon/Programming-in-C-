using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._83
{
    public class Pub
    {
        static void Main()
        {
           Raise();
        }
        public static event Action OnChange = delegate {};

        public static void Raise()
        {
            OnChange();
        }
    }
}
