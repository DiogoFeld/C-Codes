using RandomCodes.Generics;
using RandomCodes.UnderTheHoof;

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



            //Exercise.CalculateAverageDurationInMilliseconds();

            RefExample refExample = new();


            int example2 = 1;
            refExample.addOneOnRef(ref example2);

            outExp outExp = new();
            outExp.showIntPi(out example2);


            if (true)
            {
                GarbbageCollector gc = new GarbbageCollector();
            }
            GC.Collect();
        }





    }










}



