using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.Birds.predatorsBirds
{
    public class Hawk : Predators
    {
        public string FeatherColor { get; set; }
        public bool IsMigratory { get; set; }

        public Hawk(string featherColor, bool isMigratory)
        {
            FeatherColor = featherColor;
            IsMigratory = isMigratory;
        }
    }
}
