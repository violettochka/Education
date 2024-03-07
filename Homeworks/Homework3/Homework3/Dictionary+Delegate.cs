using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Dictionary_Delegate
    {
        public readonly Dictionary<string, Func<IEnumerable<int>, double>> _dictionary = new Dictionary<string, Func<IEnumerable<int>, double>>
        {
            {"Find a multiple of unique elems", MultipleUniqueElem},
            { "Find a max length subsequence of decreasing elems", MaxDecreasingSubsequenceLength},
            { "Find average number of collection" , Average},
            { "Find max sum of collection", MaxSumOfList},
            { "Find the count of the most common number in collection", CountTheMostCommonNumber}
        };
        public IReadOnlyDictionary<string, Func<IEnumerable<int>, double>> Dictionary => _dictionary.AsReadOnly();

        public static double MultipleUniqueElem(IEnumerable<int> collection)
        {
            var unigElems = collection.Distinct();
            var res = 1;
            foreach (var elem in unigElems)
            {
                res *= elem;
            }

            return res;
        }

        public static double MaxDecreasingSubsequenceLength(IEnumerable<int> collection)
        {
            double res = 1;
            int count = 1;
            foreach (var elem in collection.Skip(1))
            {
                if(collection.ElementAt(count - 1) > elem)
                {
                    count++;
                    res = Math.Max(res, count);
                }
                else
                {
                    count = 1;
                }
            }

            return res;
        }

        public static double CountTheMostCommonNumber(IEnumerable<int> collection) 
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

        public static double Average(IEnumerable<int> collection)
        {
            return collection.Average();
        }

        public static double MaxSumOfList(IEnumerable<int> collection)
        {
            double maxi = int.MinValue;
            double current = 0;

            foreach(var elem in collection)
            {
                current = Math.Max(elem, elem + current);
                maxi= Math.Max(maxi, current);
            }

            return maxi;
        }
    }
}
