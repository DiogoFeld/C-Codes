using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RandomCodes.Delegate_Events.DelegateEx;

namespace RandomCodes.Delegate_Events
{
    public class DelegateEx2
    {
        public delegate void MostrarMensagem(string message);

        public void ExDelegate()
        {
            MostrarMensagem delegate1 = ExibirMensagem;

            // Invocando o método através do delegate
            delegate1("Olá, Delegate!");

            Action<string> mostrar = msg => Console.WriteLine(msg);
            mostrar("Usando Action!");

            Func<int, int, int> somar = (a, b) => a + b;
            Console.WriteLine(somar(5, 3)); // 8


            Predicate<int> ehPar = numero => numero % 2 == 0;
            Console.WriteLine(ehPar(10)); // True
        }

        static void ExibirMensagem(string texto)
        {
            Console.WriteLine(texto);
        }


        static void EnviarEmail(string msg)
        {
            Console.WriteLine($"Email enviado: {msg}");
        }

        static void EnviarSMS(string msg)
        {
            Console.WriteLine($"SMS enviado: {msg}");
        }


    }
}
