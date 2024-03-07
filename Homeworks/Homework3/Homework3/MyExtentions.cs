using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public static class MyExtentions
    {
        public static void PrintAllElems<T>(this IEnumerable<T> collection)
        {
            foreach(var elem in collection)
            {

                Console.WriteLine(elem + "\n");

            };
        }

        public static T[] Selection<T>(this IEnumerable<T> elem, Func<T, bool> someFunction)
        {
            return elem.Where(someFunction).ToArray();
        }
    }
}
