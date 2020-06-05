using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public static class Mock
    {
        
        public static Teatcher TeatcherMock()
        {
            return new Teatcher
            {
                Id = 1,
                Name = "Newton",
                TeatcherCourses = new List<TeatcherCourse> { TeatcherCourseMock().Find(t => t.TeatcherId == 1) }
            };
        }

        public static List<TeatcherCourse> TeatcherCourseMock()
        {
            return new List<TeatcherCourse>{
                    new TeatcherCourse{TeatcherId = 1,CourseId = 1 },
                    new TeatcherCourse{TeatcherId = 2,CourseId = 2  },
                    new TeatcherCourse{TeatcherId = 3,CourseId = 3  },
                    new TeatcherCourse{TeatcherId = 4,CourseId = 4 },
                    new TeatcherCourse{TeatcherId = 5,CourseId = 6  },
                    new TeatcherCourse{TeatcherId = 1,CourseId = 6  },
                    new TeatcherCourse{TeatcherId = 2,CourseId = 7  },
                    new TeatcherCourse{TeatcherId = 4,CourseId = 8  },
                    new TeatcherCourse{TeatcherId = 5,CourseId = 9  },
                    new TeatcherCourse{TeatcherId = 3,CourseId = 7  }
                };
        }

        public static Course CourseMock()
        {
            return new Course
            {
                Id = 1,
                Name = "Piano High Level",
                TeatcherCourses = new List<TeatcherCourse> { TeatcherCourseMock().Find(t => t.CourseId == 1) }
            };
        }
    }
}
