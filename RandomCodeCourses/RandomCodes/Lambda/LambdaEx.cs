using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Lambda
{
    internal class LambdaEx
    {
        public void ExampleLambda()
        {
            var operacoes = new List<Func<int,int, int>>
        {
            (x,y) => x + 1,     // soma 1
            (x,y) => x * 2,     // multiplica por 2
            (x,y) => x * x      // quadrado
        };

            int numero = 5;
            int numero2 = 1;

            foreach (var op in operacoes)
            {
                Console.WriteLine(op(numero, numero2));
            }
        }
    }
}
