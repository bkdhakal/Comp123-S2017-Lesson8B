using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_S2017_Lesson8B
{
   public class Student : Person
    {
        // PRIVATE FIELD
        private string _studentID;
        // PUBLIC PROPERTIES
        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
            
        }
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;
        }
        public void Studies()
        {
            Console.WriteLine(this.Name + " is studying");
        }
    }
}
