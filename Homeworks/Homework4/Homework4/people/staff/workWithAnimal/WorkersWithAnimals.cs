using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.people.staff.workWithAnimal
{
    public abstract class WorkersWithAnimals : Workers
    {
        private const double SALARYFORWORKESWITHANIMALS = 20000;
        protected WorkersWithAnimals(string name, int age) : base(name, age)
        {
        }
        public override void GetSalary()
        {
            Salary += SALARYFORWORKESWITHANIMALS;
        }
    }
}
