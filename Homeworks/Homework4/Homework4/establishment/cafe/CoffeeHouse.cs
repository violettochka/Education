using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.cafe
{
    public class CoffeeHouse : Cafe
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = base.GetMenu();
            menu.Add("Coffee", 55.30);
            menu.Add("Exprecco", 35.90);
            menu.Add("Frappe", 80.00);
            menu.Add("Latte", 105.40);

            return menu;
        }
    }
}
