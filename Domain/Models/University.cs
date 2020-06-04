using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class University:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Teatcher> Teatchers { get; set; }
    }
}
