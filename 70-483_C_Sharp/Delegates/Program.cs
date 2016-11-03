using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // delegate should be outside of methods
        delegate int MyDelegate(int x, int y);

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            MyDelegate del = null;              // only one delegate to call methods

            del = calculator.Add;               // pointing delegate to a method
            Console.WriteLine(del(20,10));      // calling pointed method

            del = calculator.Substract;
            Console.WriteLine(del(20,10));

            del = calculator.ReturnLarger;
            Console.WriteLine(del.Invoke(20,10));   // optional usage of Invoke

            del = calculator.ReturnSmaller;
            Console.WriteLine(del(20,10));
        }
        
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }

        public int Substract(int c, int d)
        {
            return (c - d);
        }

        public int ReturnLarger(int x, int y)
        {
            return (x >= y ? x : y);
        }

        public int ReturnSmaller(int p, int q)
        {
            return (p >= q ? q : p);
        }
    }
}
