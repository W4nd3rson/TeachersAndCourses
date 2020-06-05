using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ICourseService
    {
        Task<Course> GetAsyncById(int Id);
        Task<IEnumerable<Course>> GetAll();
        Task<IEnumerable<Course>> GetByIdsAsync(List<int> Ids);
        Task<Course> AddCourse(Course course);
        Task<Course> UpdateCourse(Course course);
        Task DeleteCourse(int Id);
    }
}
