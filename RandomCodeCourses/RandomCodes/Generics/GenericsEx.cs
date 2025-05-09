using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Generics
{
    static class GenericsEx<T>
    {
        static void GenericExample(T example)
        {
            string f;
            
            Console.WriteLine(example.GetType());
            Console.WriteLine(example);
        }


        static void MethodExample<TExaple>()
        {

        }

    }
}
