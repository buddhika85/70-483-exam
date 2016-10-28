using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            CarIndexedCollection collection = new CarIndexedCollection();
            collection[0] = "Nissan";
            collection[1] = "Toyota";
            collection[2] = "BMW";

            Console.WriteLine("0 : " + collection[0]);
            Console.WriteLine("9 : " + collection[9]);
            Console.WriteLine("10: " + collection[10]);

            Console.ReadKey();
        }
    }

    class CarIndexedCollection
    {       
        string[] cars = new string[10];

        // indexer
        public string this[int indexVal]
        {
            get
            {
                /* return the specified index here */
                if (indexVal >= 0 && indexVal < cars.Length)
                {
                    if (string.IsNullOrWhiteSpace(cars[indexVal]))
                    { 
                        return "Do not have a value";
                    }
                    else
                    { 
                        return cars[indexVal];
                    }
                }
                else
                {                    
                    return "Invlaid index : " + indexVal + ". length is 0 to " + (cars.Length - 1);
                }
            }
            set
            {
                /* set the specified index to value here */
                if (indexVal >= 0 && indexVal < cars.Length)
                {
                    cars[indexVal] = value;
                }
            }
        }
    }    
}
