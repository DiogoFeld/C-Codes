using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Collections
{
    internal class BigOAnnotation
    {
        //O nQuadrado 
        void CompararTodos(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    Console.WriteLine($"{numeros[i]} vs {numeros[j]}");
                }
            }
        }

        // O(log n) — Tempo Logarítmico
        int BuscaBinaria(int[] numeros, int alvo)
        {
            int inicio = 0;
            int fim = numeros.Length - 1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;

                if (numeros[meio] == alvo)
                    return meio;
                else if (numeros[meio] < alvo)
                    inicio = meio + 1;
                else
                    fim = meio - 1;
            }

            return -1; // não encontrado
        }

    }
}
