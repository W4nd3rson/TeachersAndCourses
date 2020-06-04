using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class TeatcherCourse
    {
        public int TeatcherId { get; set; }
        public Teatcher Teatcher { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public TeatcherCourse(TeatcherCourse teatcherCourse)
        {
            this.TeatcherId = teatcherCourse.TeatcherId;
            this.CourseId = teatcherCourse.CourseId;
        }

        public TeatcherCourse()
        {
        }
    }
}
