using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.establishment;


namespace Homework4.people.staff.workWithPeople
{
    internal class Security : WorkWithPeople
    {
        public Security(string name, int age) : base(name, age)
        {
        }
        public void OpenEstablishment(Establishment establishment, bool isOpen)
        {
            establishment.IsOpen = isOpen;
        }
    }
}
