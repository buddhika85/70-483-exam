using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Increase(10, 10));
            Console.WriteLine("Default value added - " + Increase(10));     // optional arguments
            Console.WriteLine("Named Arguments - " + Increase(num2:11, num1:15));
            Console.ReadKey();
        }

        // num2 is an optional argument
        public static int Increase(int num1, int num2 = 1)
        {
            return num1 + num2;
        }
    }

    class Person
    {
        // field
        private int age;
        // property
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                // validation rules for the setter
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Error - invalid age");
                }
            }
        }

        public int Age1 { get; set; }

    }
}
