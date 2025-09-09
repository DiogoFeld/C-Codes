using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    public class ThreadPoolEx
    {
        public void Stuff()
        {
            Console.WriteLine("Core count " + Environment.ProcessorCount);
            Console.WriteLine("Main thread Ids: " + Thread.CurrentThread.ManagedThreadId);


            for (int l = 0; l <100; l++)
            {
                ThreadPool.QueueUserWorkItem(PrintMinus);
            }
        }
        
        static void PrintMinus(object? state)
        {
            Console.WriteLine("Printing minus signs in: " +
                Thread.CurrentThread.ManagedThreadId);


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-");
            }
        }
    }
}
