using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Employee : Person
    {
        public Employee(string name, int age)
        {
            Console.WriteLine("Inside Employee constructor");
            Name = name;
            Age = age;
        }

        public override string Work()
        {
            return "Employee working";
        }

    }
}
