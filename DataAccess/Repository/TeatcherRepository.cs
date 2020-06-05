using DataAccess.Repository.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeatchersAndCourses.DataAccess.Context;
using TeatchersAndCourses.DataAccess.Repository;

namespace DataAccess.Repository
{
    public class TeatcherRepository : Repository<Teatcher>, ITeatcherRepository
    {
        public TeatcherRepository(TeatchersAndCoursesContext context) : base(context)
        {
        }

        public Task<Teatcher> GetAsyncById(int Id)
        {
            return context.Set<Teatcher>().Include(c => c.TeatcherCourses).ThenInclude(c => c.Course).FirstOrDefaultAsync(t => t.Id == Id);
        }
    }
}
