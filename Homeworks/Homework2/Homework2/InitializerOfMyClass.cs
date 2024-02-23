using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class InitializerOfMyClass
    {
        //инициализация студента
        public static Student CreateStudent(string nameOfStudent,
                                            int group)
        {
            var student = new Student(nameOfStudent, group);
            return student;
        }

        //инициализация преподавателя
        public static Teacher CreateTeacher(string teacherName, 
                                            List<DayAvailability> availibleDayTime, 
                                            Subject subject)
        {
            var teacher = new Teacher(teacherName, availibleDayTime, subject);
            return teacher;
        }

        //инициализация предмета
        public static Subject CreateSubject(SubjectType nameSubject, 
                                            List<DayAvailability> availibleDayTime)
        {
            var subject = new Subject(nameSubject, availibleDayTime);
            return subject;
        }

        //инициализация временной доступности для преподавателя/предмета
        public static List<DayAvailability> CreateAvalibleDayTime(TimeSpan startTime, 
                                                                  TimeSpan endTime, 
                                                                  Days dayOfWeek)
        {
            var timeRangeForTeacher = new List<TimeRange>
            {
               new TimeRange(startTime, endTime),
             };

            List<DayAvailability> availibleDayTime = new List<DayAvailability>
            {
                new DayAvailability(dayOfWeek,  timeRangeForTeacher)
            };
            return availibleDayTime;
        }

        //инициализация рассписания
        public static void Schedule(Teacher teacher,
                                    int group, 
                                    Subject subject, 
                                    TimeSpan startTime, 
                                    TimeSpan endTime,
                                    Days dayOfWeek)
        {
            Schedule schedule = new Schedule();
            schedule.CreateSchedule(teacher, group, subject, dayOfWeek, startTime, endTime);


        }
        

    }
}
