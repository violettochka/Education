using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.Animals;
using Homework4.people;

namespace Homework4.establishment.restaurant
{
    public class Restaurant : Establishment
    {
        protected override Dictionary<string, double> GetMenu()
        {
            var menu = new Dictionary<string, double>()
            {
                {"Salad", 190.50 },
                {"Pasta", 209.80 },
                {"seafood", 580.70 }
            };

            return menu;
        }

        //Развлекательная программа в ресторане для поднятия настроения
        public void Entertament(List<People> people)
        {
            foreach (People persone in people)
            {
                if (!persone.Mood.Equals(Mood.Good))
                {
                    persone.Mood = Mood.Good;
                }
            }
        }
    }
}
