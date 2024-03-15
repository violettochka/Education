using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.mammals.seaAnimals
{
    public abstract class SeaAnimal : Mammals
    {
        public TypeOfSwim TypeOfSwim { get; set; }
        public abstract void CanSwim();
    }
}
