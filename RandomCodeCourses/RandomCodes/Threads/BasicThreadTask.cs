using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    public class BasicThreadTask
    {
        public async void Stuff()
        {
            Console.WriteLine("Core count " + Environment.ProcessorCount);
            Console.WriteLine("Main thread Ids: " + Thread.CurrentThread.ManagedThreadId);

            Task<int> taskResult = Task.Run(() => PrintLenght("word is a word"));
            
            Console.WriteLine("word is " + taskResult.Result) ;
            taskResult.Wait();

            Console.WriteLine("Done");

        }

        int PrintLenght(string word)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Returning word: ");

            return word.Length;
        }

    }
}