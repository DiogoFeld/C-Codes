using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.OOP
{
    public static class ExtensionInt
    {
        public static int GetNumberLenght(this int value) { 
            int result = 0;
            result = value.ToString().Length;


            return result;
        }



    }
}
