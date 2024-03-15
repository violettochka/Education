using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.people;

namespace Homework4.Animals.mammals
{
    public abstract class Mammals : Animal
    {
        public void MakeBite(People people)
        {
            people.Mood = Mood.Bad;
        } 
    }
}
