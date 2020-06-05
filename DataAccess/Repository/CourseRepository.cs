using DataAccess.Repository.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatchersAndCourses.DataAccess.Context;
using TeatchersAndCourses.DataAccess.Repository;

namespace DataAccess.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(TeatchersAndCoursesContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            return await context.Set<Course>().ToListAsync();
        }

        public Task<Course> GetAsyncById(int Id)
        {
            return context.Set<Course>().Include(c => c.TeatcherCourses).ThenInclude(c => c.Teatcher).FirstOrDefaultAsync(t => t.Id == Id);
        }

        public async Task<IEnumerable<Course>> GetByIdsAsync(List<int> Ids)
        {
            return await context.Courses.Where(c => Ids.Contains(c.Id)).ToListAsync();
        }
    }
}
