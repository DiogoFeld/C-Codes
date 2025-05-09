using RandomCodes.Exepctions;
using RandomCodes.Generics;
using RandomCodes.OOP;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RandomCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //  var result = SwitchExpression.GetIdade(32);
            //  Console.WriteLine(result);
            //      Carro carro = new Carro("smart", 156);
            //      carro.Barulho();
            //      Console.WriteLine(carro.Velocidade());

            //int numberExtension = 7862;
            //Console.WriteLine(numberExtension.GetNumberLenght());

            //Exceptions.RunExceptions();

            //GenericsEx
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



