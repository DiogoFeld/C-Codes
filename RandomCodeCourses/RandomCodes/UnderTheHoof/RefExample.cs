using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.UnderTheHoof
{
    public class RefExample
    {          

        public void addOneOnRef(ref int referenciaExmp)
        {
            referenciaExmp++;
        }
    }

    public static class RefModifierFastForwardToSummerExercise
    {
        static readonly DateTime LimiteDate = new DateTime(DateTime.Now.Year,6,21);

        public static void FastForwardToSummer(ref DateTime date)
        {
            if (date < LimiteDate) { 
                date = LimiteDate;           
            }
            else {/*do NOTHING*/ }




        }
    }
}
