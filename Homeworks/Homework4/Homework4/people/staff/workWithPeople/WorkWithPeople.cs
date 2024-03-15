using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.people.staff.workWithPeople
{
    public abstract class WorkWithPeople : Workers
    {
        private double SALARYFORWORKERSWITHPEOPLE = 15000;
        public WorkWithPeople(string name, int age) : base(name, age) { }

        public override void GetSalary()
        {
            Salary += SALARYFORWORKERSWITHPEOPLE;
        }

    }
}
