using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class DayAvailability
    {
        public Days DayOfWeek { get; set; }
        public List<TimeRange> AvailableTimeRanges { get; set; }

        public DayAvailability(Days dayOfWeek, List<TimeRange> availableTimeRanges)
        {
            DayOfWeek = dayOfWeek;
            AvailableTimeRanges = availableTimeRanges;
        }
    }
    public class TimeRange
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public TimeRange(TimeSpan startTime, TimeSpan endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }
    }
    public enum Days 
    { 
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,

    }
}
