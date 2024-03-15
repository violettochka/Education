using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.people.staff
{
    public abstract class Workers : People
    {
        protected Workers(string name, int age) : base(name, age) { }
        public double Salary;

        public abstract void GetSalary();

        public void LunchBreak()
        {
            CanEat();
        }

    }
}
