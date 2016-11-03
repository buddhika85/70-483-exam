using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    class Program
    {
        // delegate should be outside of methods
        // can be outside a class well
        delegate void MyDelegate(int x, int y);

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            MyDelegate del = null;              // only one delegate to call methods

            Console.WriteLine("\nOne Target method-------------------------------");
            del = calculator.Add;               // pointing delegate to first method
            del(20, 10);                        // calling pointed method

            // add another method
            Console.WriteLine("\nTwo Target methods------------------------------");
            del += calculator.Substract;
            del(20, 10);

            // add another three methodss
            Console.WriteLine("\nFive Target methods-----------------------------");
            del += calculator.ReturnSmaller;            
            del += calculator.ReturnLarger;
            del += calculator.Add;
            del.Invoke(20, 10);                 // optional usage of Invoke

            // remove two methods
            Console.WriteLine("\nThree Target methods----------------------------");
            del -= calculator.ReturnSmaller;
            del -= calculator.Substract;
            del.Invoke(20, 10);                 // optional usage of Invoke
        }

    }

    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add(a + b) : " + (a + b));
        }

        public void Substract(int c, int d)
        {
            Console.WriteLine("Substract(c - d) : " + (c - d));
        }

        public void ReturnLarger(int x, int y)
        {
            Console.WriteLine("ReturnLarger(x, y) : " + (x >= y ? x : y));
        }

        public void ReturnSmaller(int p, int q)
        {
            Console.WriteLine("ReturnSmaller(p,q) : " + (p >= q ? q : p));
        }
    }
}
