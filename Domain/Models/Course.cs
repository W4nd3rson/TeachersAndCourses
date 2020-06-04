using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Course:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeatcherCourse> TeatcherCourses { get; set; }
        public ICollection<CoursesUniversity> CoursesUniversities { get; set; }
    }
}
