using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Teatcher:BaseEntity
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }
        public List<TeatcherCourse> TeatcherCourses { get; set; } = new List<TeatcherCourse>();
        public ICollection<TeatchersUniversity> TeatchersUniversities { get; set; }
        [NotMapped]
        public ICollection<Course> Courses { get => GetCourses(); }

        private ICollection<Course> GetCourses()
        {
            var courses = new List<Course>();

            if (TeatcherCourses != null && TeatcherCourses.Count > 0)
            {
                foreach (var teatcherCourse in this.TeatcherCourses)
                {
                    courses.Add(teatcherCourse.Course);
                }
            }

            return courses;
        }
    }
}
