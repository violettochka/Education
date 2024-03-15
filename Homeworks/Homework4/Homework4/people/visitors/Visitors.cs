using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.establishment;

namespace Homework4.people.visitors
{
    public abstract class Visitors : People
    {
        public double Wallet { get; set; } = 500;
        public TypeOfTickets Ticket;
        protected Visitors(string name, int age) : base(name, age) { }

        public abstract void GetTicket();

        public void ShooseAndPayForDish(Establishment establishment, string dish)
        {
            var menu = establishment.ShowMenu();
            double price;
            if (menu.TryGetValue(dish, out price))
            {
                if(Wallet >= price)
                {
                    Wallet -= price;
                    this.CanEat();
                }
            };
        }
    }
}
