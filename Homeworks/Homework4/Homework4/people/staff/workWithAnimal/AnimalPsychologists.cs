using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.Animals;


namespace Homework4.people.staff.workWithAnimal
{
    public class AnimalPsychologists : WorkersWithAnimals
    {
        public AnimalPsychologists(string name, int age) : base(name, age)
        {
        }
        public void MakeMood(Animal animal)
        {
            animal.Mood = (animal.Mood.Equals(Mood.Bad)) ? animal.Mood = Mood.Good : animal.Mood;
        }
    }
}
