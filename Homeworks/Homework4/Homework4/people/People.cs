using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.Animals;
using Homework4.Animals.mammals;

namespace Homework4.people
{
    public abstract class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Satiety { get; set; } = 100;
        public Mood Mood { get; set; } = Mood.Average;

        protected People(string name, int age)
        {
            Name = name;
            Age = age;
        }
        protected void CanEat()
        {
            Satiety = (Satiety < 100) ? 100 : Satiety;
        }

        public void PetTheAnimal(Mammals mammals)
        {
            if(mammals.Mood.Equals(Mood.Good) || mammals.Mood.Equals(Mood.Average))
            {
                Mood = Mood.Good;
            }
            else if (mammals.Mood.Equals(Mood.Bad))
            {
                mammals.MakeBite(this);

            }
        }
    }
}
