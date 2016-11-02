using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface_Implementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();

            // explicit interface implemnatation calls via 
            // explicit casting to the interface type
            ((IFirst)cc).DoThis();
            ((ISecond)cc).DoThis();
            ((IFirst)cc).DoThis(6);
            ((ISecond)cc).DoThis(20);

            Console.ReadKey();
        }
    }

    interface IFirst
    {
        void DoThis();
        void DoThis(int x);
    }

    interface ISecond
    {
        void DoThis();
        int DoThis(int x);
    }

    public class ChildClass : IFirst, ISecond
    {
        //----------------- SAME SIGNATURE, SAME RETURN --------------------
        void IFirst.DoThis()
        {
            Console.WriteLine("IFIRST - DoThis()");
        }

        void ISecond.DoThis()
        {
            Console.WriteLine("ISECOND - DoThis()");
        }
        //----------------- SAME SIGNATURE, SAME RETURN --------------------

        //----------------- SAME SIGNATURE, DIFFERENT RETURN ---------------
        void IFirst.DoThis(int x)
        {
            Console.WriteLine("IFIRST - DoThis(int x)");
        }

        int ISecond.DoThis(int x)
        {
            Console.WriteLine("ISECOND - DoThis(int x)");
            return x;
        }
        //----------------- SAME SIGNATURE, DIFFERENT RETURN ---------------
    }
}
