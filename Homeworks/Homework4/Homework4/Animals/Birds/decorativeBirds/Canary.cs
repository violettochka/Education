using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.Birds.decorativeBirds
{
    public class Canary : DecorativeBirds
    {
        public override void CanSing()
        {
            Voice = "Sing song like a Canary";
            Console.WriteLine(Voice);
        }
    }
}
