using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_ders
{
    internal class Student
    {
        string name;
        string surname;
        string group;
        int _age;
        double point;

        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 18) 
                {
                    _age = value;
                }
            }
        }
        public Student(string name, string surname, string group, int age, double point)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.Age = age;
            this.point = point;
            if(point>65)
            {
                Console.WriteLine("Mezun olub");
            }
            else
            {
                Console.WriteLine("Bedbaxt kesilib"); 
            }
        }

        
    }
}
