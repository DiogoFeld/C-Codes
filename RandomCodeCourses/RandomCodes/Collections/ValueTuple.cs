using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Collections
{
    internal class ValueTuple
    {
        void Example()
        {
            (string nome, int idade) pessoa = ("Maria", 25);

            Console.WriteLine($"Nome: {pessoa.nome}, Idade: {pessoa.idade}");

            //Value Tuple - semantica de alor

            Tuple<string, int> pessoa2 = Tuple.Create("João", 30);

            Console.WriteLine($"Nome: {pessoa2.Item1}, Idade: {pessoa2.Item2}");

        }



    }
}
