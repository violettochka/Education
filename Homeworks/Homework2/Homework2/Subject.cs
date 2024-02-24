using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Subject
    {
        public SubjectType NameSubject { get; set; }
        public List<DayAvailability> AvailibleDayTime { get; set; }

        public Subject(SubjectType NameSubject, List<DayAvailability> AvalibleDayTime) 
        {
            this.NameSubject = NameSubject;
            this.AvailibleDayTime = AvalibleDayTime;
        }

        public override string ToString()
        {
            return NameSubject.ToString();
        }
    }
}
