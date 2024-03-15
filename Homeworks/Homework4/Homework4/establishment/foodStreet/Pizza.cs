using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.foodStreet
{
    public class Pizza : FastFood
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = base.GetMenu();
            menu.Add("Margherita", 89.99);
            menu.Add("Pepperoni", 90.99);
            menu.Add("Vegetarian", 149.49);
            menu.Add("Hawaiian", 109.99);

            return menu;
        }
    }
}
