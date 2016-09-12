using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Kumar Sangakkara", 30);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Work());

            Person person = new Employee("Mitch Starc", 25);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Work());
            Console.ReadKey();
        }
    }
}
