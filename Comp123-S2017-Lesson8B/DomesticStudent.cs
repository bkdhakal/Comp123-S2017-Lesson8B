using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_S2017_Lesson8B
{
    public class DomesticStudent : Student
    {
        public string DomesticAdress { get; private set; } // READ ONLY
        public DomesticStudent(string name, int age, string studentID)
            :base(name,age, studentID)
        {

        }
        public void SetDomesticAdress(string address)
        {
            this.DomesticAdress = address;
        }
    }
}
