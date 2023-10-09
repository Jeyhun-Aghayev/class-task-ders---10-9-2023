using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_ders
{
    internal class Person
    {
        public string Surname;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value.Length< 2) 
                {
                    Console.WriteLine("Ad ikiden boyuk olmalidi");
                }
                else
                {
                    _name= value;
                }
            }
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
