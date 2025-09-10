using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    internal class ExerciseThreadsTask
    {
        public static void RunSimpleTask()
        {
            Console.WriteLine("Before task starting.");

            var task = Task.Run(() =>
            {
                for (int i = 1; i < 4; ++i)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Iteration number " + i);
                }
            });

            task.Wait();
            Console.WriteLine("The task has finished.");
        }
    }
}
