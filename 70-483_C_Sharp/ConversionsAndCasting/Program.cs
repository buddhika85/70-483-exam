using System;

namespace ConversionsAndCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            long l = i;     // implicit cast - putting content of a small bucket to bigger bucket, always safer

            // explicit cast - putting big bucket data to a smaller bucket, there might be data loses    
            byte ub = 255;   // unsigned byte - maximum limit is utlised with 255
            short s = 50;
            ub = (byte) s;         // explicit cast is required   
            Console.WriteLine("1 : " + ub);

            s = 256;            // exceeds unsigned byte - maximum limit which is 255
            ub = (byte) s;      // riskier - potential data loss
            Console.WriteLine("2 : " + ub);

            // trying to convert a decimal number to whole number - 
            double d = 15.5;
            i = (int) d;        // riskier - potential data loss of precision
            Console.WriteLine("3 : " + i);

            try
            {
                i = int.Parse(d.ToString());
                Console.WriteLine("4 : " + i);
            }
            catch (Exception e)
            {
                Console.WriteLine("4 : " + e.Message);
            }

            i = Convert.ToInt32(d);
            Console.WriteLine("5 : " + i);

            bool b = int.TryParse(d.ToString(), out i);
            Console.WriteLine("6 : " + b + " with " + i);

            Console.ReadKey();
        }
    }
}
