using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_S2017_Lesson8B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Person person = new Person("Krishna", 30);
            person.Talks();
            Console.WriteLine("\n");
            Student student = new Student("Bobo", 20, "123456789A");
            student.Studies();
            student.Talks();
            DomesticStudent domestic = new DomesticStudent("Chrish", 19, "123456788B");
            domestic.Talks();
        }
    }
}
