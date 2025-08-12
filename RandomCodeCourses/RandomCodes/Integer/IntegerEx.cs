using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Integer
{
    internal class IntegerEx
    {

    }


    public static class CheckedFibonacciExercise
    {
        public static IEnumerable<int> GetFibonacci(int n)
        {
            List<int> result = new List<int>();
            //      0.1.1.2.3.5.7
            int first = 0;
            int second = 1;
                    int total;
            
            for (int i = 0; i < n; i++)
            {
                if (i == 0)               
                    result.Add(first);               
                else if(i == 1)               
                    result.Add(second);
                else
                {
                    total = first + second;
                    result.Add(total);
                    first = second;
                    second = total;
                }                  
            }
            return result;
        }
    }

    public static class FloatingPointNumbersExercise
    {
        public static bool IsAverageEqualTo(
            this IEnumerable<double> input, double valueToBeChecked)
        {

            double sum = 0;
            int count = 0;

            foreach (double x in input)
            {
                if (double.IsNaN(x) || double.IsInfinity(x))
                    throw new ArgumentException();

                sum += x;
                count++;
            }
            var average = sum / count;
            const double tolerance = 0.00001;
            return Math.Abs(average - valueToBeChecked) < tolerance;



            return false;
            //your code goes here
        }
    }


}
