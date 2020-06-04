using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeatchersAndCourses.DataAccess.Context;

namespace DataAccess
{
    public static class DataInicialize
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TeatchersAndCoursesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TeatchersAndCoursesContext>>()))
            {
                if (context.Teatchers.Any() || context.Courses.Any())
                {
                    return;
                }

                context.Universities.AddRange(
                    new University
                    {
                        Name = "Itau University",
                    }
                );

                context.SaveChanges();

                context.Courses.AddRange(
                    new Course
                    {
                        Name = "Matematica",
                    },

                    new Course
                    {
                        Name = "Piano High Level",
                    },

                    new Course
                    {
                        Name = "Noções sobre tempo e espaço",
                    },

                    new Course
                    {
                        Name = "Seleção Natural",
                    },

                    new Course
                    {
                        Name = "Física",
                    },

                     new Course
                     {
                         Name = "Geografia",
                     },

                     new Course
                     {
                         Name = "Matematica Aplicada",
                     },

                     new Course
                     {
                         Name = "Filosofia",
                     },

                      new Course
                      {
                          Name = "Sociologia",
                      },

                       new Course
                       {
                           Name = "Algebra",
                       },

                       new Course
                       {
                           Name = "Geometria",
                       }
                );

                var coursesUniversity = new[] {
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 1 },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 2  },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 3  },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 4 },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 5  },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 6  },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 7  },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 8  },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 9  },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 10 },
                    new CoursesUniversity{UniversityId = context.Universities.First().Id,CourseId = 11 },
                };

                context.CoursesUniversities.AddRange(coursesUniversity);

                context.SaveChanges();

                context.Teatchers.AddRange(
                    new Teatcher
                    {
                        Name = "Newton",
                    },

                    new Teatcher
                    {
                        Name = "Mozart",
                    },

                    new Teatcher
                    {
                        Name = "Einstein",
                    },

                    new Teatcher
                    {
                        Name = "Darwin",
                    },

                    new Teatcher
                    {
                        Name = "Rick",
                    }
                );

                var teatchersCourses = new[] {
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

                var teatchersUniversities = new[] {
                    new TeatchersUniversity{TeatcherId = 1,UniversityId = context.Universities.First().Id },
                    new TeatchersUniversity{TeatcherId = 2,UniversityId = context.Universities.First().Id  },
                    new TeatchersUniversity{TeatcherId = 3,UniversityId = context.Universities.First().Id  },
                    new TeatchersUniversity{TeatcherId = 4,UniversityId = context.Universities.First().Id },
                    new TeatchersUniversity{TeatcherId = 5,UniversityId = context.Universities.First().Id  }
                };

                context.TeatcherCourses.AddRange(teatchersCourses);
                context.TeatchersUniversities.AddRange(teatchersUniversities);

                context.SaveChanges();
            }
        }

    }
}

