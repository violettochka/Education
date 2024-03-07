using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Dictionary_Delegate_Realization
    {
        public static void DelegateRealization()
        {
            var exeplar = new Dictionary_Delegate();
            Console.WriteLine("Enter an operation");
            string operation = Console.ReadLine();
            if (exeplar.Dictionary.TryGetValue(operation, out var delegateOperation))
            {
                Console.WriteLine("enter a numbers please");
                var elems = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                Console.WriteLine(delegateOperation(elems));
            }
        }
    }
}
