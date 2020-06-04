using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Teatcher:BaseEntity
    {
        public string Name { get; set; }
        public List<TeatcherCourse> TeatcherCourses { get; set; }
        public ICollection<TeatchersUniversity> TeatchersUniversities { get; set; }
    }
}
