using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RandomCodes.Collections
{
    internal class Exercicios
    {

    }



    public class PairOfArrays<TLeft, TRight>
    {
        private readonly TLeft[] _left;
        private readonly TRight[] _right;


        public PairOfArrays(
            TLeft[] left, TRight[] right)
        {
            _left = left;
            _right = right;
        }

        public (TLeft left, TRight right) this[int indexInLeft, int indexInRight]
        {
            get
            {
                return (_left[indexInLeft], _right[indexInRight]);
            }
            set
            {
                _left[indexInLeft] = value.left;
                _right[indexInRight] = value.right;
            }
        }

        //your code goes here
    }



    public static class HashSetsUnionExercise
    {
        public static HashSet<T> CreateUnion<T>(
            HashSet<T> set1, HashSet<T> set2)
        {
            HashSet<T> combinedSet = new HashSet<T>(set1);
            // Adds elements from set2 to the new combinedSet.
            combinedSet.UnionWith(set2);
            return combinedSet;

            //your code goes here
        }
    }

    public static class StackExtensions
    {
        public static int DoesContainAny(this Stack<string> stack, params string[] words)
        {
            int result = stack.Count(x => words.Contains(x));
            return result;
        }

        //your code goes here
    }

    public class YieldExercise
    {
        public static IEnumerable<T> GetAllAfterLastNullReversed<T>(IList<T> list)
        {

            int lastNullIndex = -1;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == null)
                {
                    lastNullIndex = i;
                    break;
                }
            }

            // Step 2: Yield items after the last null in reversed order
            for (int i = list.Count - 1; i > lastNullIndex; i--)
            {
                yield return list[i];

            }
        }
        //your code goes here
    }


}

