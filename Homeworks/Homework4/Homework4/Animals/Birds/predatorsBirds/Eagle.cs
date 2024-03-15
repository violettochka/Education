using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.Birds.predatorsBirds
{
    public class Eagle : Predators
    {
        public TypeOfSpecies Species { get; set; }
        public Eagle(TypeOfSpecies species)
        {
            Species = species;
        }

    }
}
