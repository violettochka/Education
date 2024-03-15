using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.cafe
{
    public class Сonfectionery : Cafe
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = base.GetMenu();
            menu.Add("Cake", 90.75);
            menu.Add("Apple pie", 150.90);
            menu.Add("Cobbler", 80.70);

            return menu;
        }
    }
}
