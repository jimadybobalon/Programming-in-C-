using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._48___New_Keyword_on_Declarations
{
    class Program
    {

        public class BaseC{
            public string className = "BaseC";
            public Point point = new Point();

            public void Invoke(){
                Console.WriteLine("Base: " + point.x + ", " + point.y);
            }

            public class Point{
                public int x = 0;
                public int y = 0;
            }
        }

        public class DerivedC : BaseC{
            new public string className = "DerivedC";
            new public Point point = new Point();
            
            new public void Invoke(){
                Console.WriteLine("Derived: " + point.x + ", " + point.z);
            }

            new public class Point{
                public int x = 1;
                public int z = 1;
            }
        }

        static void Main(string[] args){

            DerivedC derivedC = new DerivedC();
            derivedC.Invoke();
            Console.WriteLine("X: " + derivedC.className);

            BaseC baseC = new BaseC();
            baseC.Invoke();
            Console.WriteLine("X: " + baseC.className);

            baseC = derivedC;
            baseC.Invoke();
            Console.WriteLine("X: " + baseC.className);
            
            derivedC = null;
            derivedC = (DerivedC)baseC;
            derivedC.Invoke();
            (derivedC as BaseC).Invoke();
            Console.WriteLine("X: " + derivedC.className);
            Console.WriteLine("X: " + (derivedC as BaseC).className);



            Console.Read();
        }
    }
}
