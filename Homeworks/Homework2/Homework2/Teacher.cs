using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        public List<DayAvailability> AvailibleDayTime { get; set; }
        public Subject Subject { get; set; }

        public Teacher(string TeacherName, List<DayAvailability> AvalibleDayTime, Subject Subject)
        {
            this.TeacherName = TeacherName;
            this.AvailibleDayTime = AvalibleDayTime;
            this.Subject = Subject;


        }

        public override string ToString()
        {
            return TeacherName;
        }

        public void GetTeacherSchedule(List<Schedule> schedule)
        {
            var currentTeacher = schedule.Where(current => current.Teacher == this);
            foreach (var elem in currentTeacher)
            {
                Console.WriteLine(elem.ToString());
            }
        }


    }
}
