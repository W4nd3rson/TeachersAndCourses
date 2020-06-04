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
        public DbSet<University> Universities { get; set; }
        public DbSet<TeatcherCourse> TeatcherCourses { get; set; }
        public DbSet<CoursesUniversity> CoursesUniversities { get; set; }
        public DbSet<TeatchersUniversity> TeatchersUniversities { get; set; }
        public TeatchersAndCoursesContext(DbContextOptions<TeatchersAndCoursesContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PreventPluralizedNames(modelBuilder);

            modelBuilder.Entity<TeatcherCourse>().HasKey(t => new { t.TeatcherId, t.CourseId });
            modelBuilder.Entity<TeatchersUniversity>().HasKey(tu => new { tu.TeatcherId, tu.UniversityId});
            modelBuilder.Entity<CoursesUniversity>().HasKey(c => new { c.CourseId, c.UniversityId });
            
            modelBuilder.Entity<TeatcherCourse>()
                .HasOne<Teatcher>(tc => tc.Teatcher)
                .WithMany(s => s.TeatcherCourses)
                .HasForeignKey(tc => tc.TeatcherId);

            modelBuilder.Entity<TeatcherCourse>()
                .HasOne<Course>(tc => tc.Course)
                .WithMany(c => c.TeatcherCourses)
                .HasForeignKey(tc => tc.CourseId);

            modelBuilder.Entity<TeatchersUniversity>()
                .HasOne<Teatcher>(tc => tc.Teatcher)
                .WithMany(c => c.TeatchersUniversities)
                .HasForeignKey(tc => tc.TeatcherId);

            modelBuilder.Entity<CoursesUniversity>()
               .HasOne<Course>(tc => tc.Course)
               .WithMany(c => c.CoursesUniversities)
               .HasForeignKey(tc => tc.CourseId);
        }

        private void PreventPluralizedNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teatcher>().ToTable("Teatcher");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<University>().ToTable("University");
            modelBuilder.Entity<TeatcherCourse>().ToTable("TeatcherCourse");
            modelBuilder.Entity<CoursesUniversity>().ToTable("CoursesUniversity");
            modelBuilder.Entity<TeatchersUniversity>().ToTable("TeatchersUniversity");
        }
    }
}
