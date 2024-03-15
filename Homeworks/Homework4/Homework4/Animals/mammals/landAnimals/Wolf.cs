using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.mammals.landAnimals
{
    public class Wolf : LandAnimal
    {
        public override void CanRun()
        {
            if (Satiety > 30)
            {
                Speed = Speed.Slow;
            }
        }
    }
}
