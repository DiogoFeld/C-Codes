using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    public class threadApply
    {
        public void Stuff()
        {
            Console.WriteLine("Core count " + Environment.ProcessorCount);
            Console.WriteLine("Main thread Ids: " + Thread.CurrentThread.ManagedThreadId);

            Thread thread1 = new Thread(() => PrintMinus());
            Thread thread2 = new Thread(() => PrintPlus());

            thread1.Start();
            thread2.Start();       
        }
        void PrintPlus()
        {
            Console.WriteLine("Printing plus signs in: " +
                Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("+");
            }
        }
        void PrintMinus()
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
