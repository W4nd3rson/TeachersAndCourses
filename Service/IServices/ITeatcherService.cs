using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ITeatcherService
    {
        Task<Teatcher> GetAsyncById(int Id);
        Task<IEnumerable<Teatcher>> GetAll();
        Task<Teatcher> AddTeatcher(Teatcher teatcher);
        Task<Teatcher> UpdateTeatcher(Teatcher teatcher);
        Task DeleteTeatcher(int Id);
    }
}
