using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.Animals;
using Homework4.Animals.Birds;
using Homework4.Animals.Birds.predatorsBirds;


namespace Homework4.people.staff.workWithAnimal
{
    public class FeedingWorkers : WorkersWithAnimals
    {
        public FeedingWorkers(string name, int age) : base(name, age)
        {
        }
        public void Feed(Animal animal)
        {
            animal.Satiety = (animal.Satiety < 100) ? 100 : animal.Satiety;
            if(animal is Birds)
            {
                Birds bird = (Birds)animal;
                bird.StrengthForFly = (bird.StrengthForFly < 80) ? bird.StrengthForFly += 20 : bird.StrengthForFly;
                
            }
            if(animal is Predators)
            {
                Predators predator = (Predators)animal;
                predator.StrengthForHunt = (predator.StrengthForHunt < 90) ? predator.StrengthForHunt += 10 : predator.StrengthForHunt;
            }
        }
    }
}
