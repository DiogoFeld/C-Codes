using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Generics
{
    static class FunctionExample
    {



    }

   public class Pair<T>
    {
        public T First { get; private set; }
        public T Second { get; private set; }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public void ResetFirst()
        {
            First = default;
        }     
        public void ResetSecond()
        {
            Second = default;
        }
    }


    /*
     
    This class should expose public ResetFirst and ResetSecond methods that set the First or the Second property to the default values for their type.
    */
}
