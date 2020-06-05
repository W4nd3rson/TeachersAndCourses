using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeatchersAndCourses.DataAccess.Repository.IRepository;

namespace DataAccess.Repository.IRepository
{
    public interface ICourseRepository : IRepository<Course>
    {
        Task<Course> GetAsyncById(int Id);
        Task<IEnumerable<Course>> GetAllAsync();
        Task<IEnumerable<Course>> GetByIdsAsync(List<int> Ids);
    }
}
