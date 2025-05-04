using System.Diagnostics.Tracing;
using System.Linq;

namespace RandomCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //  var result = SwitchExpression.GetIdade(32);
            //  Console.WriteLine(result);


        }

        public static class StringsTransformator
        {
            public static string TransformSeparators(
                string input,
                string originalSeparator,
                string targetSeparator)
            {
                string result;

                var array = input.Split(originalSeparator);
                result = string.Join(targetSeparator, array);


                return result;
                //your code goes here
            }
        }




    }










}



