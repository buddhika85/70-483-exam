using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_and_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single threading - main thread at work\n");
            DemoSingleThread();
            Console.WriteLine("\n\nMulti threading - main thread and a new thread at work simultaniously\n");
            DemoMultiThreading();

            Console.ReadKey();
        }

        // demos main thread at work
        private static void DemoSingleThread()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }

        // demo main thread and another thread working together
        private static void DemoMultiThreading()
        {
            // new thread 
            Thread newThread1 = new Thread(NewThread1Method);
            newThread1.Start();

            // code for main thread to execute
            for (int i = 0; i < 1000; i++)
            {
                DoSomeWork();
                Console.Write("O");
            }
        }

        // code to execute for new thread1
        private static void NewThread1Method()
        {
            for (int i = 0; i < 1000; i++)
            {
                DoSomeWork();
                Console.Write(".");                
            }
        }

        // just some work for the threads to do
        public static void DoSomeWork()
        {
            int x = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    x += j;
                }
            }
        }
    }
}
