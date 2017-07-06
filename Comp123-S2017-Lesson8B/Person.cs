using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_S2017_Lesson8B
{/// <summary>
/// this is a person class
/// </summary>
   public class Person
    {
        // PRIVATE INSTANCE VARIABLES
        private string _name;
        private int _age;
        // PUBLIC PROPERTIES---
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
            
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        // CONSTRUCTORS---
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Talks()
        {
            Console.WriteLine(this.Name + "is talking");
        }

    }
}
