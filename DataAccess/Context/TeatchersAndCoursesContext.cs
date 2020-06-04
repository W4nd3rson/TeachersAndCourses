using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeatchersAndCourses.DataAccess.Context
{
    public class TeatchersAndCoursesContext : DbContext
    {
        public DbSet<Teatcher> Teatchers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TeatcherCourse> TeatcherCourses { get; set; }
        public TeatchersAndCoursesContext(DbContextOptions<TeatchersAndCoursesContext> options) : base(options)
        {
            
        }
    }
}
