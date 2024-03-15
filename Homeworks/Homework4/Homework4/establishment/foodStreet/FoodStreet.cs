using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.establishment.foodStreet
{
    public abstract class FoodStreet : Establishment
    {
        public  void GetFoodOut()
        {
            if (Menu.Any())
            {
                Random random = new Random();
                var randomDish = Menu.Keys.ElementAt(random.Next(Menu.Count));
                Menu.Remove(randomDish);
                Console.WriteLine($"The dish '{randomDish}' has been taken out.");
            }
            else
            {
                Console.WriteLine("There are no dishes available for takeout.");
            }
        }
    }
}
