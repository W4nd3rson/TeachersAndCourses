using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Course : BaseEntity
    {
        [Display(Name = "Nome do Curso")]
        public string Name { get; set; }
        public ICollection<TeatcherCourse> TeatcherCourses { get; set; }
        public ICollection<CoursesUniversity> CoursesUniversities { get; set; }

        [NotMapped]
        public ICollection<Teatcher> Teatchers { get => GetTeatchers(); }

        private ICollection<Teatcher> GetTeatchers()
        {
            var teatchers = new List<Teatcher>();

            if (TeatcherCourses != null && TeatcherCourses.Count > 0)
            {
                foreach (var teatcherCourse in this.TeatcherCourses)
                {
                    teatchers.Add(teatcherCourse.Teatcher);
                }
            }

            return teatchers;
        }
    }
}
