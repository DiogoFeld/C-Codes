using RandomCodes.Collections;
using RandomCodes.ComplexType;
using RandomCodes.Generics;
using RandomCodes.Integer;
using RandomCodes.String;
using RandomCodes.UnderTheHoof;
using static System.Net.Mime.MediaTypeNames;

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

            //SortedList<int> sortedList = new SortedList<int> { 1, 2, 3 };
            //nao consegue implementar     


            //NullLables nullLables = new NullLables();
            //nullLables.DoNull();


            //Reflection reflection = new Reflection();
            //reflection.Test();


            //var stack = new Stack<string>();
            //stack.Push("a");
            //stack.Push("B");
            //stack.Push("c");

            //stack.DoesContainAny("a","b","c");


            //charEx charEx = new charEx();
            //charEx.Example();


            CheckedFibonacciExercise.GetFibonacci(10);
            StringBuilderExercise.Reverse("abc");

        }





    }










}



