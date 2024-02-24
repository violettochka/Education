using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Schedule
    {
        public static List<Schedule> schedule = new List<Schedule>();
        public int Group { get; set; }
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
        public Days DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        private bool AvalibleTeacherState {  get; set; }

        public Schedule()
        {

        }

        public Schedule(int group,
                        Teacher teacher,
                        Subject subject,
                        Days dayOfWeek,
                        TimeSpan startTime,
                        TimeSpan endTime)
        {
            Group = group;
            Teacher = teacher;
            Subject = subject;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
        }

        public void CreateSchedule(Teacher teacher,
                                   int group,
                                   Subject subject,
                                   Days dayOfWeek,
                                   TimeSpan startTime,
                                   TimeSpan endTime)
        {
            if (
                TeacherIsAvalible(teacher, dayOfWeek, startTime, endTime) 
                && SubjectIsAvalible(subject, dayOfWeek, startTime, endTime)
                )
            {
                schedule.Add(new Schedule(group, teacher, subject, dayOfWeek, startTime, endTime));
                Console.WriteLine("Рассписание создано успешно");
            }
            else
            {
                Console.WriteLine("Рассписание не было создано. Проверьте временную доступность преподавателя/предмета");
            }
        }

        public bool TeacherIsAvalible(Teacher teacher,
                                      Days dayOfWeek,
                                      TimeSpan startTime,
                                      TimeSpan endTime)
        {
            AvalibleTeacherState = false;
            DayAvailability currentDay = null;
            foreach(var searchDay in teacher.AvailibleDayTime)
            {
                if (searchDay.DayOfWeek == dayOfWeek) 
                {
                    currentDay = searchDay;
                    break;
                }
            }
            if (currentDay != null)
            {
                foreach(var searchingTime in currentDay.AvailableTimeRanges)
                {
                    if(startTime >= searchingTime.StartTime  && endTime <= searchingTime.EndTime)
                    {
                        AvalibleTeacherState = true;
                        break;
                    }
                }
            }

            return AvalibleTeacherState;
        }

        public bool SubjectIsAvalible(Subject subject,
                                      Days dayOfWeek,
                                      TimeSpan startTime,
                                      TimeSpan endTime)
        {
            bool res = false;
            DayAvailability currentday = null;
            foreach (var searchDay in subject.AvailibleDayTime)
            {
                if (searchDay.DayOfWeek == dayOfWeek) 
                { 
                    currentday = searchDay;
                    break;
                }
            }
            if (currentday != null)
            {
                foreach(var searchingTime in currentday.AvailableTimeRanges)
                {
                    if(startTime >= searchingTime.StartTime && startTime <= searchingTime.EndTime)
                    {
                        res = true;
                        break;
                    }
                }
            }

            return res;
        }

        public static void ShowAllSchedule()
        {
            foreach (var elem in schedule)
            {
                Console.WriteLine(elem.ToString());
            }
        }

        public static void GetScheduleForGroup(int group)
        {
            var studentSchedule = schedule.Where(current => current.Group == group);
            if(studentSchedule != null)
            {
                Console.WriteLine($"Рассписание для группы {group}\n");
            } 
            foreach (var elem in studentSchedule)
            {
                Console.WriteLine(elem.ToString());
            }
        }

        public void UpdateSchedule(Teacher teacher,
                                        Days dayOfWeek,
                                        TimeSpan startTime,
                                        TimeSpan endTime)
        {
            if (AvalibleTeacherState == false)
            {
                schedule.RemoveAll(el => el.Teacher == teacher);
            }
        }

        public override string ToString()
        {
            return $"Преподаватель: {Teacher},\n " +
                $"предмет: {Subject},\n " +
                $"день: {DayOfWeek},\n" +
                $"Группа студентов: {Group}, \n" +
                $" Время начала: {StartTime},\n" +
                $"Время окончания: {EndTime}\n";
        }
    }
}
