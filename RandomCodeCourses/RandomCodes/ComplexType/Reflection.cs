using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.ComplexType
{
    public  class Reflection
    {
        public void Test()
        {
            BigDoggo testObj = new BigDoggo()
            {
                nome = "test",
                idade = 1
            };

            var type = testObj.GetType()
                .GetProperties();

            foreach (var t in type) { 
                Console.WriteLine(t.ToString());            
            }

        }





    }


    [AttributeUsage(AttributeTargets.Property)]
    public class MustBeLargerThan : Attribute
    {
        public int Min { get; }

        public MustBeLargerThan(int min)
        {
            this.Min = min;
        }  
    }

    class BigDoggo
    {
        public int idade { get; set; }
        public string nome{ get; set; }
    }


}
