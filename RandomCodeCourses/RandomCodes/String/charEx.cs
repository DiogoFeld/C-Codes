using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.String
{
    internal class charEx
    {
        public void Example()
        {
            char word = 'a';
            char number = '3';
            char pontuation = '?';



            var result = char.IsLetter(word);
            var result1 = char.IsDigit(number);
            var result2 = char.IsUpper(number);

            int resultINt = (int)word;

            for(char c='A';c <= 'Z'; c++)
            {
                Console.WriteLine(c);
            }

        }
    }



    public static class StringBuilderExercise
    {
        public static string Reverse(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = input.Length -1;i>=0;i-- )
            {
                stringBuilder.Append(input[i]);
            }         


            return stringBuilder.ToString();
        }
    }
    /*
        for input "abc" result shall be "cba"
        for input "Hello" result shall be "olleH"
        for input "" result shall be ""
        for input "one two three" result shall be "eerht owt eno"
    */

}
