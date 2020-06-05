using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeatchersAndCourses.DataAccess.Repository.IRepository;

namespace DataAccess.Repository.IRepository
{
    public interface ITeatcherRepository : IRepository<Teatcher>
    {
        Task<Teatcher> GetAsyncById(int Id);
    }
}
