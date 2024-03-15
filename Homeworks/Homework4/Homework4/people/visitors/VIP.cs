using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.people.visitors
{
    public class VIP : Visitors
    {
        public VIP(string name, int age) : base(name, age) { }

        public override void GetTicket()
        {
            if(Wallet >= 300)
            {
                Wallet -= 300;
                Ticket = TypeOfTickets.VIP;

                return;
            }
            Console.WriteLine("You dont have enougth money");
        }
    }
}
