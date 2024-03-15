using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.people.visitors
{
    public class Adult : Visitors
    {
        public Adult(string name, int age) : base(name, age)
        {
        }

        public override void GetTicket()
        {
            if (Wallet >= 200)
            {
                Wallet -= 200;
                Ticket = TypeOfTickets.Adult;

                return;
            }
            Console.WriteLine("You dont have enougth money");
        }
    }
}
