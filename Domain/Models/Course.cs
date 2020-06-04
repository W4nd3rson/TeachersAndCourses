using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Course:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Teatcher> Courses { get; set; }
        public virtual ICollection<University> Universities { get; set; }
    }
}
