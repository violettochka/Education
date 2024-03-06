using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Dictionary_Delegate
    {
        public static Dictionary<string, Func<List<int>, int>> dictionary = new Dictionary<string, Func<List<int>, int>>
        {
            {"Find a multiple of unique elems", MultipleUniqueElem},
            { "Find a max length subsequence of decreasing elems", MaxDecreasingSubsequenceLength},
            { "Find average number of collection" , Average},
            { "Find max sum of collection", MaxSumOfList},
            { "Find the count of the most common number in collection", CountTheMostCommonNumber}
        };

        public static int MultipleUniqueElem(List<int> collection)
        {
            var unigElems = collection.Distinct();
            int res = 1;
            foreach (var elem in unigElems)
            {
                res *= elem;
            }

            return res;
        }

        public static int MaxDecreasingSubsequenceLength(List<int> collection)
        {
            int res = 1;
            for(int i = 1; i < collection.Count; i++)
            {
                if (collection[i - 1] > collection[i])
                {
                    res += 1;
                }
                else
                {
                    res = 1;
                }
            }

            return res;
        }

        public static int CountTheMostCommonNumber(List<int> collection) 
        {
            var dictionary = new Dictionary<int, int>();
            foreach(int elem in collection)
            {
                if (dictionary.ContainsKey(elem))
                {
                    dictionary[elem]++;
                }
                else
                {
                    dictionary[elem] = 1;
                }
            }

            return dictionary.Values.Max();
        }

        public static int Average(List<int> collection)
        {
            int res = 0;
            foreach (var elem in collection)
            {
                res += elem;
            }

            return res/2;
        }

        public static int MaxSumOfList(List<int> collection)
        {
            int maxi = int.MinValue;
            int current = 0;

            foreach(var elem in collection)
            {
                current = Math.Max(elem, elem + current);
                maxi= Math.Max(maxi, current);
            }

            return maxi;
        }
    }
}
