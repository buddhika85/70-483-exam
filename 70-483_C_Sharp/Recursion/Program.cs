using System;
using System.Linq;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facorial of 3 is : " + Factorial(3));
            Console.WriteLine("Array as a CSV : " + ArrayAsCsv(new[] { "A", "B", "C", "D", "E", "F"}));
            Console.WriteLine("3rd number of Fibonacci sequence is : " + Fibonacci(3));
            Console.WriteLine("8th number of Fibonacci sequence is : " + Fibonacci(8));

            Console.ReadKey();
        }

        /*        
            The Fibonacci sequence is a sequence of numbers where the first two numbers are 1
            and 1, and every other number in the sequence after it is the sum of the two numbers before it.
            So the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
            which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
            number: 2 + 3 = 5. This keeps going forever.
            The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
            Because one number is defined by the numbers before it, this sets up a perfect opportunity for
            using recursion.
            Your mission, should you choose to accept it, is to create a method called Fibonacci, which
            takes in a number and returns that number of the Fibonacci sequence. So if someone calls
            Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If someone
            calls Fibonacci(8), it would return 21.         
        */
        private static int Fibonacci(int number)
        { 
            if (number == 1 || number == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number -1);
            }
        }

        private static string ArrayAsCsv(string[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }
            else
            {
                string lastElement = array.Reverse().ToArray()[array.Length -1];
                array = array.Skip(1).ToArray();
                return lastElement + " , " + ArrayAsCsv(array);
            }
        }

        private static int Factorial(int value)
        {
            if (value == 1)
            {
                return 1; // 1 s factorial value is 1
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}
