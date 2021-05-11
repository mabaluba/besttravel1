using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace besttravel
{
    public class Program
    {
        public static class SumOfK
        {
            public static int? ChooseBestSum(int t, int k, List<int> ls)
            {
                //var listOfValues = new SortedSet<int>(ls).Reverse().ToList();//sorted - упорядоченное множество(набор), hash - неупорядоченное
                var listOfValues = ls.OrderBy(i=>i);
                var listOfVariants = new HashSet<int>();


                #region oldAlgo
                //for (int i = 0; i <= listOfValues.Count() - k; i++)
                //{
                //    var c = 0;
                //    var arr = new int[k];
                //    arr[0] = listOfValues[i];
                //    for (int j = i + 1; j <= ls.Count - (k - 1); j++)
                //    {
                //        ls.CopyTo(j, arr, 1, k - 1);
                //        listOfVariants.Add(arr.Sum());
                //        c++;
                //    }
                //}
                #endregion



                var a  = listOfVariants.Where(i=> i<=t);
                return a.Any() ? a.Max() : (int?) null;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(SumOfK.ChooseBestSum(230, 3, new List<int> {91, 74, 73, 85, 73, 81, 87 }));
            //Console.WriteLine(SumOfK.ChooseBestSum(163, 3, new List<int> {50}));
            Console.WriteLine(SumOfK.ChooseBestSum(331, 4, new List<int> {50, 55, 56, 57, 58, 50, 91, 74, 73, 85, 73, 81, 87, 91, 74, 73, 85, 73, 81, 87, 91, 74, 73, 85, 73, 81, 87}));

        }
    }
}
