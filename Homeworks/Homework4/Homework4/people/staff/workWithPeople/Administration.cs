using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.people.visitors;


namespace Homework4.people.staff.workWithPeople
{
    internal class Administration : WorkWithPeople
    {
        public Administration(string name, int age) : base(name, age)
        {
        }
        public void EntranceIntoZoo(Visitors visitor)
        {
            if(visitor.Ticket != TypeOfTickets.None)
            {
                Enviroment.Visitors.Add(visitor);
            }
        }
    }
}
