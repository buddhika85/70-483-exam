using System;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            object o = i;       // Boxing - implicit cast
            Console.WriteLine("boxing : " + o);

            o = 30;
            i = (int) o;        // Unboxing - explicit cast required
            Console.WriteLine("unboxing  : " + i);

            Console.ReadKey();
        }
    }
}
