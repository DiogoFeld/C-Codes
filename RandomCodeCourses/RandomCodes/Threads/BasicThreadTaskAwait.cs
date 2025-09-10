using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    public class BasicThreadTaskAwait
    {
        public async void Stuff()
        {
            Console.WriteLine("Core count " + Environment.ProcessorCount);
            Console.WriteLine("Main thread Ids: " + Thread.CurrentThread.ManagedThreadId);

            Task<int> taskResult = Task.Run(() => PrintLenght("word is a word"));
            Task<int> taskResult2 = Task.Run(() => PrintLenght("another word  is a word"));

            Task.WaitAll(taskResult, taskResult2);
            Console.WriteLine("word is " + taskResult2.Result);

            Console.WriteLine("Done");

        }

        int PrintLenght(string word)
        {
            Console.WriteLine("Returning word: ");

            return word.Length;
        }


    }



    public class Exercise12
    {
        public static void RunSimpleTask()
        {
            Console.WriteLine("Before task starting.");


            for (int i = 1; i < 4; i++)
            {
                Task.Run(() => Console.WriteLine("Iteration number X " + i));
                Thread.Sleep(1000);
            }
            Task.WaitAll();
            Console.WriteLine("The task has finished.");
        }
    }

}