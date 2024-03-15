using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.Birds
{
    public abstract class Birds : Animal
    {
        public int StrengthForFly { get; set; } = 100;
        public  void CanFly()
        {
            if (StrengthForFly > 50)
            {
                Console.WriteLine("Bird can fly");
                StrengthForFly -= 30;
                return;
            }
            Console.WriteLine("The bird is too tired, it needs to eat");
        }
    }
}
