using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson2_Csh
{
    internal class Person //:IComparable<Person>
    {
        private string name;
        //private int age;
        public string Name { /*set;*/ get { return name; } }
        public int Age { set; get; }
        
        public void Print()
        {
            Console.WriteLine($"Имя {Name} возраст {Age}");
            //или Console.WriteLine("Имя{0} возраст {1}", Name, Age);
        }
        public Person(string _name) 
        { 
            name = _name;
        }

        private int myVar;
        public int MyProperty {
            get { return myVar; }
            set
            {
                if (value % 2 == 0)
                {
                    myVar = value;
                }
                else
                {
                    myVar = 0;
                }
            }      
        }
    }
}
