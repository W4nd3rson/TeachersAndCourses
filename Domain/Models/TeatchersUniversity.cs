using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class TeatchersUniversity
    {
        public int UniversityId { get; set; }
        public University University { get; set; }
        public int TeatcherId { get; set; }
        public Teatcher Teatcher { get; set; }
    }
}
