using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CoursesUniversity
    {
        public int UniversityId { get; set; }
        public University University { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
