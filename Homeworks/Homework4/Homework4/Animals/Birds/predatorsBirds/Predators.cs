using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Animals.Birds.predatorsBirds
{
    public abstract class Predators : Birds
    {
        public List<string> rodents = new List<string>() { "mouse", "rat", "hamster"};
        public int StrengthForHunt { get; set; } = 100;
        public void CanHunts()
        {
            if(StrengthForHunt > 70)
            {
                if(rodents != null)
                {
                    rodents.Remove(rodents[0]);
                    Mood = (Mood.Equals(Mood.Bad) || Mood.Equals(Mood.Average)) ? Mood.Good : Mood;
                    StrengthForHunt -= 10;
                }
            }
        }
    }
}
