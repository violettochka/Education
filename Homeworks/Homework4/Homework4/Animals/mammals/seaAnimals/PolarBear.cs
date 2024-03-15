using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.mammals.seaAnimals
{
    public class PolarBear : SeaAnimal
    {
        public override void CanSwim()
        {
            TypeOfSwim = TypeOfSwim.Swimming;
        }
    }
}
