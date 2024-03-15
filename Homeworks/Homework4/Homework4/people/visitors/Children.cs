using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.people.visitors
{
    public class Children : Visitors
    {
        public Children(string name, int age) : base(name, age) { }

        public override void GetTicket()
        {
            if(Wallet >= 150)
            {
                Wallet -= 150;
                Ticket = TypeOfTickets.Child;

                return;
            }
            Console.WriteLine("You dont have enougth money");
        }
    }
}
