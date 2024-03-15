using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.foodStreet
{
    public class FruitStreet : FoodStreet
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = new Dictionary<string, double>()
            {
                { "Apple", 10.99 },
                { "Banana", 20.99 },
                { "Orange", 15.49 },
                { "Strawberry", 25.49 }
            };

            return menu;
        }
    }
}
