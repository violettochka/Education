using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.foodStreet
{
    public class StreetIceCream : FoodStreet
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = new Dictionary<string, double>()
            {
                { "Vanilla", 30.99 },
                { "Chocolate", 45.49 },
                { "Strawberry", 49.99 },
                { "Mint Chip", 50.49 }
            };

            return menu;
        }
    }
}
