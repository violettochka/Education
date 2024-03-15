using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.Birds.decorativeBirds
{
    public abstract class DecorativeBirds : Birds
    {
        public string Voice;
        public abstract void CanSing();
    }
}
