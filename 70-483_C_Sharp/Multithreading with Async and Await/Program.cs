using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_with_Async_and_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            CountToTenAsync();
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Main thread - " + i);
            }
        }

        private async static Task CountToTenAsync()
        {
            Console.WriteLine("Im gonna start counting to 10 Asynchronously");
            // below await keyword tells - start a BG thread and execute CountAndDisplay() method
            // and release the caller thread to do anyhting outside of this method
            //await Task.Run(() => {
                Task<bool> doneCounting = CountAndDisplay(10);
                if (doneCounting.Result)
                {
                    Console.WriteLine("I counted to 10 Asynchronously");
                }                
            //});               
        }

        private static Task<bool> CountAndDisplay(int n)
        {
            bool doneCounting = false;
            for (int i = 1; i <= n; i++)
            {
                Thread.Sleep(300);                   
                Console.WriteLine("--------------------------- Background thread by await - " + i);
                doneCounting = true;
            }           
            return Task.FromResult(doneCounting);
        }
    }
}
