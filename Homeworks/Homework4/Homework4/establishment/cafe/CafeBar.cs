using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.cafe
{
    public class CafeBar : Cafe
    {

        protected override Dictionary<string, double> GetMenu()
        {
            var menu = base.GetMenu();
            menu.Add("Vine", 350.90);
            menu.Add("Vodka", 90.90);
            menu.Add("Pivo", 80.00);
            menu.Add("Viski", 380.60);

            return menu;

        }
    }
}
