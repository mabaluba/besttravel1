using System;
using System.Collections.Generic;
using System.Linq;

namespace besttravel
{

    public static class SumOfK
    {
        public static int? ChooseBestSum(int t, int k, List<int> ls)
        {
            var listOfVariants = new SortedSet<int>();
            var b = ls.Combinations(k);
            foreach (var combination in b)
            {
                listOfVariants.Add(combination.Sum());
            }
            var a = listOfVariants.Where(i => i <= t);
            return a.Any() ? a.Last() : (int?)null;
        }
        public static IEnumerable<T[]> Combinations<T>(this List<T> values, int k)
        {
            if (k < 0 || values.Count < k)
                yield break; // invalid parameters, no combinations possible

            // generate the initial combination indices
            var combIndices = new int[k];
            for (var i = 0; i < k; i++)
            {
                combIndices[i] = i;
            }

            while (true)
            {
                // return next combination
                var combination = new T[k];
                for (var i = 0; i < k; i++)
                {
                    combination[i] = values[combIndices[i]];
                }
                yield return combination;

                // find first index to update
                var indexToUpdate = k - 1;
                while (indexToUpdate >= 0 && combIndices[indexToUpdate] >= values.Count - k + indexToUpdate)
                {
                    indexToUpdate--;
                }

                if (indexToUpdate < 0)
                    yield break; // done

                // update combination indices
                for (var combIndex = combIndices[indexToUpdate] + 1; indexToUpdate < k; indexToUpdate++, combIndex++)
                {
                    combIndices[indexToUpdate] = combIndex;
                }
            }
        }
        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SumOfK.ChooseBestSum(230, 3, new List<int> {91, 74, 73, 85, 73, 81, 87 }));
            Console.WriteLine(SumOfK.ChooseBestSum(163, 3, new List<int> {50}));
            Console.WriteLine(SumOfK.ChooseBestSum(331, 4, new List<int> {50, 55, 56, 57, 58, 50, 91, 74, 73, 85, 73, 81, 87, 91, 74, 73, 85, 73, 81, 87, 91, 74, 73, 85, 73, 81, 87}));
            Console.ReadKey();
        }
    }
}
