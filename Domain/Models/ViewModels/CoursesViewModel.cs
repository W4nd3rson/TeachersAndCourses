using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.ViewModels
{
    public class CoursesViewModel
    {
        public Course Course { get; set; }

        public ICollection<Teatcher> Teatchers { get; set; }
    }
    
}
