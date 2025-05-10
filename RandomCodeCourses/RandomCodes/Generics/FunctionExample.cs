using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RandomCodes.Generics
{
    static class FunctionExample
    {

    }


    public class Exercise
    {
        public void TestMethod()
        {
            Func<int, bool, double> someMethod1 = Method1;
            Func<DateTime> someMethod2 = Method2;
            Action<string, string> someMethod3 = Method3;
        }

        public double Method1(int a, bool b) => 0;
        public DateTime Method2() => default(DateTime);
        public void Method3(string a, string b) { }
    }


    public class Exercise2
    {
        public Func<string, int> GetLength = s => s.Length;
        public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1, 11);// your code goes here;
                                                                                       
    }



    /*
     GetLength stores a function taking a string and returning its length.
    
    GetRandomNumberBetween1And10 stores a parameterless function generating a random number between 1 and 10.
     
     */

}
