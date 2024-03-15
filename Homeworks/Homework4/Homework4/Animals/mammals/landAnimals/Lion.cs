using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.mammals.landAnimals
{
    public class Lion : LandAnimal
    {
        public override void CanRun()
        {
            if(Satiety > 70)
            {
                Speed = Speed.VeryFast;
            }   
        }
    }
}
