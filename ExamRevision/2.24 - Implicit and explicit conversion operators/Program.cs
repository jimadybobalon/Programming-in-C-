using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._24___Implicit_and_explicit_conversion_operators
{
    class Program
    {

        class Money
        {
            public Money(decimal amount)
            {
                Amount = amount;
            }
            public decimal Amount { get; set; }

            public static implicit operator decimal (Money money)
            {
                return money.Amount;
            }

            public static explicit operator int (Money money)
            {
                return (int)Math.Floor(money.Amount);
            }
        }

        static void Main(string[] args)
        {
            Money money = new Money(5.32m);

            Console.WriteLine(money);

            Console.WriteLine((int)money);
            
            Console.Read();
        }
    }
}
