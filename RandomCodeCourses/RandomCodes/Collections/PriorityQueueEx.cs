using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Collections
{
    internal class PriorityQueueEx
    {
        void DoStuff()
        {
            // Cria a fila de prioridade
            var fila = new PriorityQueue<string, int>();

            // Adiciona elementos com prioridades (quanto menor o número, maior a prioridade)
            fila.Enqueue("Tarefa C", 3);
            fila.Enqueue("Tarefa A", 1);
            fila.Enqueue("Tarefa B", 2);

            // Remove e imprime na ordem de prioridade
            while (fila.Count > 0)
            {
                string tarefa = fila.Dequeue();
                Console.WriteLine(tarefa);
            }
        }

    }
}
