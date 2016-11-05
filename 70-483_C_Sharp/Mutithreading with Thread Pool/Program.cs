using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutithreading_with_Thread_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a foreground thread 
            Thread fgt = new Thread(RunForeGroundThread);
            fgt.IsBackground = false;   
            fgt.Start();

            // creating a backgroud thread via ThreadPool
            Task bgt = Task.Run(() => 
                {
                    for (int i = 1; i <= 7; i++)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("-----------------------Background Thread : " + i);
                    }
                }
            );

        }

        // Method that foreground thread executes
        private static void RunForeGroundThread()
        {
            for (int i = 1; i <= 7; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("ForeGround Thread : " + i);
            }
        }
    }
}
