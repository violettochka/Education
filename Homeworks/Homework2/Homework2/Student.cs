using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Student
    {
        public string NameOfStudent { get; set; }
        public int Group { get; private set; }

        public Student(string NameOfStudent, int Group)
        {
            this.NameOfStudent = NameOfStudent;
            this.Group = Group;
        }

        public void GetStudentSchedule(List<Schedule> schedule)
        {
            var currentStudent = schedule.Where(current => current.Group == this.Group);
            foreach (var elem in currentStudent)
            {
                Console.WriteLine(elem.ToString());
            }
        }
        public override string ToString()
        {
            return NameOfStudent;
        }

    }
}
