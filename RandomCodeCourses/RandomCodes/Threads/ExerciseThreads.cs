using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    internal class ExerciseThreads
    {
        public static void RunThreads()
        {
            for (int i = 0; i < 3; ++i)
            {
                var thread = new Thread(() =>
                {
                    Console.WriteLine($"Hello from thread with ID: " + Thread.CurrentThread.ManagedThreadId);
                });
                thread.Start();
            }
        }
    }
}
