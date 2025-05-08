using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Exepctions
{
    public static class Exceptions
    {
        public static void RunExceptions()
        {

            try
            {
                int resultFailed = int.Parse("boom");

                bool result = int.TryParse("2",out int int2);
                if (!result)
                {
                    throw new ExpetionMaker("shit crazy YO");
                }

            }
            catch (ExpetionMaker ex) 
            { 
                string ytyt = "";

            }
            catch (Exception ex)
            {
                string ytyt = "";
            }

        }

    }



    public class ExpetionMaker : Exception
    {
        public ExpetionMaker() { }
        public ExpetionMaker(string? message) : base(message) { }
        public ExpetionMaker(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
