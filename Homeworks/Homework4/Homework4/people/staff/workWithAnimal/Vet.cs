using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4.Animals;


namespace Homework4.people.staff.workWithAnimal
{
    public class Vet : WorkersWithAnimals
    {
        public Vet(string name, int age) : base(name, age) { }

        public void Core(Animal animal)
        {
            if(animal.Health < 100)
            {
                animal.Health = 100;
            }
        }

    }
}
