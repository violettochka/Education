using System.Collections.Generic;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание студентов
            var student = InitializerOfMyClass.CreateStudent("Vika", 3);
            var student1 = InitializerOfMyClass.CreateStudent("Oleg", 3);
            var student2 = InitializerOfMyClass.CreateStudent("Marina", 5);
            var student3 = InitializerOfMyClass.CreateStudent("Vlad", 5);

            //создание временной доступности для преподавателя/предмета
            var teaher1Time = InitializerOfMyClass.CreateAvalibleDayTime(TimeSpan.FromHours(9), TimeSpan.FromHours(16), Days.Monday);
            var subjectTime = InitializerOfMyClass.CreateAvalibleDayTime(TimeSpan.FromHours(10), TimeSpan.FromHours(15), Days.Monday);

            //создание предметов
            var geometry = InitializerOfMyClass.CreateSubject(SubjectType.Geometry, subjectTime);
            var oop = InitializerOfMyClass.CreateSubject(SubjectType.OOP, subjectTime);

            var teacher = InitializerOfMyClass.CreateTeacher("Volodimir", teaher1Time, geometry);
            var teacher2 = InitializerOfMyClass.CreateTeacher("Katerina", teaher1Time, oop);

            //создание рассписаний
            InitializerOfMyClass.Schedule(teacher, 5, geometry, TimeSpan.FromHours(10), TimeSpan.FromHours(12), Days.Monday);
            InitializerOfMyClass.Schedule(teacher2, 3, oop, TimeSpan.FromHours(13), TimeSpan.FromHours(15), Days.Monday);

            // просмотр всего рассписания
            Schedule.ShowAllSchedule();

            //просмотр рассписания конкретной группы
            Schedule.GetScheduleForGroup(3);

            //получение рассписания для конкретного преподавателя
            teacher.GetTeacherSchedule(Schedule.schedule);

            //получение рассписания для конкретного пользователя
            student.GetStudentSchedule(Schedule.schedule);
        }
    }
}
