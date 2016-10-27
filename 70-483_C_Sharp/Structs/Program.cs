using System;

namespace Structs
{

    public struct MyStruct
    {
        //int x = 5;    // cannot iniitialise in structs
        public int x;
        public int y;

        // structs cannot have default parameter less contructors
        public MyStruct(int a, int b)
        {
            x = a;
            y = b;
        }

        public int Add()
        {
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // using strcuts with new keyword
            MyStruct ms1 = new MyStruct(10, 5);
            Console.WriteLine(ms1.Add());

            // using structs without new keyword
            // In this case the public fields needs to be initialised explicity before using
            MyStruct ms2;
            ms2.x = 10;
            ms2.y = 10;
            Console.WriteLine(ms2.Add());

            Console.ReadKey();
        }
    }
}
