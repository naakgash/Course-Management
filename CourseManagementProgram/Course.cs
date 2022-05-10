using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAutomationProgram
{
    internal class Course
    {
        internal string _courseName { get; set; }
        internal DateTime _courseStartDate { get; set; }
        internal DateTime _courseFinishDate { get; set; }
        internal string _dayName { get; set; }
        internal int _courseHourseWeekly { get; set; }
        internal int _courseHourseTotally { get; set; }
    }
}
