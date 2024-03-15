using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals
{
    public abstract class Animal
    {
        public Mood Mood { get;  set; } = Mood.Average;
        public int Health { get;  set; } = 100;

        public int Satiety { get; set; } = 100;

    }
}
