using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._40
{
    class Program
    {

        interface ILeft{
            void Move();
        }

        interface IRight{
            void Move();
        }
        class MoveableOject : ILeft, IRight{
            void ILeft.Move() {
                Console.WriteLine("Left");
            }

            void IRight.Move() {
                Console.WriteLine("Right");
            }
        }

        static void Main(string[] args){

            MoveableOject moveableOject = new MoveableOject();

            (moveableOject as IRight).Move();

            (moveableOject as ILeft).Move();

            Console.Read();

        }
    }
}
