using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public static class CreateLinq
    {
        public static void CreateLinqElem() 
        {
            var selectElems = Request.collection.Where(elem => elem.TimeStamp <= DateTime.Now);
            selectElems.PrintAllElems();

            Console.WriteLine("---------------------------------------------------------");

            var selectElems2 = Request.collection.Where(elem => elem.Data.Message.Length >= 10);
            selectElems2.PrintAllElems();

            Console.WriteLine("---------------------------------------------------------");

            var groupElems = Request.collection.GroupBy(elem => elem.TimeStamp < DateTime.Today ? "Early request" : "New request");
            foreach(var group in groupElems)
            {
                Console.WriteLine(group.Key + "\n");
                foreach(var elem in group)
                {
                    Console.WriteLine(elem + "\n");
                }
            }

            Console.WriteLine("---------------------------------------------------------");

            var union = selectElems.Union(selectElems2);
            union.PrintAllElems();

            Console.WriteLine("---------------------------------------------------------");

            var sortedElems = Request.collection.OrderBy(elem => elem.TimeStamp);
            sortedElems.PrintAllElems();

            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
