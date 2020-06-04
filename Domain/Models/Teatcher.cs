using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Teatcher:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<University> Universities { get; set; }
    }
}
