using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Threads
{
    public class Challenge1Thread
    {

        public static Task Test(string? input)
        {
            var task = Task.Run(() => ParseToIntAndPrint(input))
             .ContinueWith(t =>
             {
                 if (t.Exception is not null)
                 {
                     var ex = t.Exception.InnerException;

                     if (ex is ArgumentNullException)
                     {
                         Console.WriteLine("The input is null.");
                     }
                     else if (ex is FormatException)
                     {
                         Console.WriteLine("The input is not in a correct format.");
                     }
                     else if (ex is ArgumentOutOfRangeException)
                     {
                         Console.WriteLine("Unexpected exception type.");
                         throw ex; // repropaga para deixar a Task em estado Faulted
                     }
                 }
             });
            return task;
        }

        private static void ParseToIntAndPrint(string? input)
        {
            if (input is null)
            {
                throw new ArgumentNullException();
            }

            if (long.TryParse(input, out long result))
            {
                if (result > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("The number is too big for an int.");
                }
                Console.WriteLine("Parsing successful, the result is: " + result);
            }
            else
            {
                throw new FormatException();
            }
        }



    }
}
