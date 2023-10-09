using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_ders
{
    internal class Employee:Person
    {
        
        private double _salary;
        bool HasCertificate;
        public double Salary 
            { 
                get
                {
                    return _salary;
                } 
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Salary 0-dan boyuk olmalidi");
                    }
                    else
                    {
                    _salary = value;
                    }
                }
            }
        public Employee(string name, string surname, double salary, bool hasCertificate):base(name,surname)
        {
             
            HasCertificate = hasCertificate;
            Salary = salary;
        }
        public void GetNameSurname()
        {
            Console.WriteLine($"Name: {Name} \nSurname: {Surname} Salary: {Salary}");
        }
    }
}
