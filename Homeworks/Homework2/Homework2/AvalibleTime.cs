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
}
