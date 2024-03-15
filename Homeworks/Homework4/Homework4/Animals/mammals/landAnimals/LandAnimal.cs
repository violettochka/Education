using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.mammals.landAnimals
{
    public abstract class LandAnimal : Mammals
    {
        public Speed Speed {  get; set; }

        public abstract void CanRun();
    }
}
