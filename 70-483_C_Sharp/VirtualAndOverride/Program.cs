using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{

    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base - method 1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Base - method 2");
        }

        public virtual void Method3()
        {
            Console.WriteLine("Base - method 3");
        }
    }

    class DerivedClass : BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Derived - method 1");
        }

        public override void Method2()
        {
            Console.WriteLine("Derived - method 2");
        }

        public new void Method3()
        {
            Console.WriteLine("Derived - method 3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.Method1();
            bc.Method2();
            bc.Method3();
            Console.ReadKey();

            DerivedClass dc = new DerivedClass();
            dc.Method1();
            dc.Method2();
            dc.Method3();
            Console.ReadKey();

            BaseClass bcdc = new DerivedClass();
            bcdc.Method1();
            bcdc.Method2();
            bcdc.Method3();
            Console.ReadKey();
        }
    }
}
