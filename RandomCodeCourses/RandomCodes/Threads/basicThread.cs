using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    public class basicThread
    {
        public void Stuff()
        {
            Console.WriteLine("Core count " + Environment.ProcessorCount);
            Console.WriteLine("Main thread Ids: " +  Thread.CurrentThread.ManagedThreadId);

            PrintPlus();
            PrintMinus();
        }

        void PrintPlus()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("+");
            }
        }    
        
        void PrintMinus()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-");
            }
        }


    }
}
