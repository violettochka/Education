using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.foodStreet
{
    public class Burger : FastFood
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = base.GetMenu();
            menu.Add("Classic Burger", 79.99);
            menu.Add("Cheeseburger", 69.99);
            menu.Add("Bacon Burger", 109.49);
            menu.Add("Veggie Burger", 129.49);

            return menu;

        }
    }
}
