using DataAccess.Repository.IRepository;
using Domain.Models;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public async Task<Course> GetAsyncById(int Id)
        {
            return await courseRepository.GetAsyncById(Id);
        }

        public async Task<Course> AddCourse(Course course)
        {
            courseRepository.Insert(course);
            return course;
        }

        public async Task DeleteCourse(int Id)
        {
            courseRepository.Delete(Id);
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            return courseRepository.GetAll();
        }

        
        public async Task<IEnumerable<Course>> GetByIdsAsync(List<int> Ids)
        {
            return await courseRepository.GetByIdsAsync(Ids);
        }

        public async Task<Course> UpdateCourse(Course course)
        {
            courseRepository.Update(course);
            return course;
        }
    }
}
