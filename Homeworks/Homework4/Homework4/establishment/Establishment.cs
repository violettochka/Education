using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.people;
using Homework4.people.visitors;

namespace Homework4.establishment
{
    public abstract class Establishment
    {
        public Dictionary<string, double> Menu;
        public bool IsOpen { get; set; } = false;
        protected abstract Dictionary<string, double> GetMenu();

        public Dictionary<string, double> ShowMenu()
        {
            Menu = GetMenu();

            return GetMenu();
        }

    }
}
