using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.Accelerate();

            Bicycle b = new Bicycle();
            Console.ReadKey();
        }
    }

    class Bicycle
    {
        public Bicycle()
        {
            Console.WriteLine("Bicycle - instance constructor");
        }

        static Bicycle()
        {
            Console.WriteLine("Bicycle - static constructor");
        }
    }

    // if the class is static, all its members needs to be static
    static class Car
    {
        private static string brand;
        static Car()
        {
            Console.WriteLine("car static constructor");
        }        

        public static string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public static void Accelerate()
        {
            Console.WriteLine("Accelereate");
        }
    }
}
