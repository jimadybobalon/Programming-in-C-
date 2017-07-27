using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._43___Generic_Type_Interfaces
{
    class Program
    {

        interface IRepository<T> where T : Student{
            T FindById(int id);
            IEnumerable<T> All(); 
        }

        class Student{
            public string name = "Student";
            public int id = 0;
            public int age = 0;
            public int year = 1;
        }
        
        class Students : IRepository<Student>{
            public Dictionary<int, Student> students;

            public Student FindById(int id){
                return students[id];
            }

            public IEnumerable<Student> All(){
                return students.Values;
            } 
        }
        
        /////////////////////////////////////////////////////////

        class VulnerableStudent : Student{
            public string info;
        }

        class VulnerableStudents : IRepository<VulnerableStudent>{
            public Dictionary<int, VulnerableStudent> students;

            public VulnerableStudent FindById(int id)
            {
                return students[id];
            }

            public IEnumerable<VulnerableStudent> All()
            {
                return students.Values;
            }
        }

        /////////////////////////////////////////////////////////

        static void Main(string[] args){

            Students studentRepo = new Students{
                students = new Dictionary<int, Student>{
                    {12, new Student { name = "Person Guy", id = 12 } }
                    ,{15, new Student { name = "Test", id = 15 } }
                    ,{100, new Student { name = "Test", id = 100, age = 100 } }
                    ,{1, new Student { id = 1, age = 1 } }
                    ,{0, new Student { } }
                }
            };

            //Console.WriteLine("Student 1's age: " + (studentRepo as IRepository<Student>).FindById(1).age);
            //Console.WriteLine("Student 12's name: " + studentRepo.FindById(12).name);

            foreach (Student s in studentRepo.All()) {
                Console.WriteLine(s.name + ", " + s.id + ", " + s.age + ", " + s.year);
            }

            Console.Read();

        }
    }
}
