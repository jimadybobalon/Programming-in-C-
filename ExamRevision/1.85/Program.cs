using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._85
{
    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }

    public class Pub
    {
        private static event EventHandler<MyArgs> onChange = delegate { };
        public static event EventHandler<MyArgs> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock(onChange)
                {
                    onChange -= value;
                }
            }
        }

        public static void Raise()
        {
            onChange(onChange, new MyArgs(42));
        }

        static void Main(string[] args)
        {
            Raise();
        }
    }
}
