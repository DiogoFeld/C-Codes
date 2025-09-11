using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    public class AwaitTask
    {
        public void DoStuff()
        {

            var tasks = new[]
            {
                Task.Run(() => ReturnLenght("Hello")),
                Task.Run(() => ReturnLenght("Holla")),
                Task.Run(() => ReturnLenght("Hi"))
            };

            Task.Factory.ContinueWhenAll(tasks, completedTask =>
            Console.WriteLine(string.Join(", ", completedTask.Select(task => task.Result)))).Wait();
        }



        internal int ReturnLenght(string word)
        {
            return word.Length;
        }

    }


    public class Exercise
    {
        public static Task<string> FormatSquaredNumbersFrom1To(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N cannot be smaller than 0.");
            }

            return Task.Run(() => GenerateSquaredFrom1To(n))
               .ContinueWith(taskOfGeneratingNumbers =>
                Format(taskOfGeneratingNumbers.Result));
        }

        private static IEnumerable<int> GenerateSquaredFrom1To(int n)
        {
            return Enumerable.Range(1, n).Select(number => number * number);
        }

        private static string Format(IEnumerable<int> numbers)
        {
            return string.Join(", ", numbers);
        }
        //your code goes here
    }




}
