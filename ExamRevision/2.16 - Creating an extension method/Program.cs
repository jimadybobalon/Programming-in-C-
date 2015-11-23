using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16
{

    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {

            Product p = new Product();

            p.Price = 15.0m;

            Console.WriteLine(p.Discount());

            Console.Read();
        }
    }
}
