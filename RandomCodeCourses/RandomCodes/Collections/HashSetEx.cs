using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Collections
{
    internal class HashSetEx
    {
        void Examples()
        {
            HashSet<string> nomes = new HashSet<string>();

            nomes.Add("João");
            nomes.Add("Maria");
            nomes.Add("Ana");
            nomes.Add("João"); // Ignorado, já existe

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine(nomes.Contains("Maria")); // true
            nomes.Remove("Ana");


            HashSet<int> A = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> B = new HashSet<int>() { 3, 4, 5 };

            A.UnionWith(B);        // A = {1, 2, 3, 4, 5}
            A.IntersectWith(B);    // A = {3}
            A.ExceptWith(B);       // A = {1, 2} (remove os que existem em B)


        }

    }
}
