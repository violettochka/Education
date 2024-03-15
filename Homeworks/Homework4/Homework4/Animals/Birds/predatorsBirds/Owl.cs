using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.Birds.predatorsBirds
{
    public class Owl : Predators
    {
        public string Habitat { get; set; }
        public int WingSpan { get; set; }

        public Owl(string habitat, int wingSpan)
        {
            Habitat = habitat;
            WingSpan = wingSpan;
        }
    }
}
