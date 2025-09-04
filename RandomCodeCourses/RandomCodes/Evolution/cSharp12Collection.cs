using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Evolution
{
    internal class cSharp12Collection
    {
        public void showMethods()
        {
            int[] number = [1, 2, 3, 4];
            List<int> list = [1, 2, 3, 4];
            HashSet<int> set = [.. list, ..number];
        }
       
    }




}
