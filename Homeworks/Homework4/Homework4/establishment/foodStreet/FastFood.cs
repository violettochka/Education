using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.foodStreet
{
    public class FastFood : FoodStreet
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = new Dictionary<string, double>()
            {
                { "French Fries", 79.49 },
                { "Chicken Nuggets", 109.99 },
                { "Hot Dog", 80.99 },
            };

            return menu;
        }
    }
}
