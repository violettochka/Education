using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.cafe
{
    public class Cafe : Establishment
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = new Dictionary<string, double>()
            {
                {"Salad", 190.50 },
                {"Pasta", 209.80 },
                {"Steik", 315.70 }
            };
            return menu;
        }
    }
}
