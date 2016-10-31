using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Abcdef";
            string b = "abcdef";

            Console.WriteLine(a + " is first cap? " + a.IsFirstCap());
            Console.WriteLine(b + " is first cap? " + b.IsFirstCap());

            Car car = new Car();            

            Console.WriteLine(car.Accelerate());
            Console.WriteLine(car.AccelerateSafly());   // note extended method is also called with original class object

            Console.ReadKey();
        }
    }

    // extension class for string
    public static class StringFirstCap
    {
        // this extnsion method will be added to the string class
        public static bool IsFirstCap(this string value)       // note the usage of this keyword to indicate extension added class
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                if (char.IsUpper(value[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    // original car class
    public class Car
    {        
        public string Accelerate()
        {
            return "Accelarate";
        }
    }

    // extension class for Car
    public static class CarSafeAccelerate
    {
        public static string AccelerateSafly(this Car c)
        {
            return "If raod way safe, accelerate from slowly, else reduce speed accordingly";
        }
    }
}
