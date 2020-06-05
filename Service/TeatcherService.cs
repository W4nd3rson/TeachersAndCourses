using DataAccess.Repository.IRepository;
using Domain.Models;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TeatcherService : ITeatcherService
    {
        private ITeatcherRepository teatcherRepository;
        public TeatcherService(ITeatcherRepository teatcherRepository)
        {
            this.teatcherRepository = teatcherRepository;
        }

        public async Task<Teatcher> AddTeatcher(Teatcher teatcher)
        {
            teatcherRepository.Insert(teatcher);
            return teatcher;
        }

        public async Task DeleteTeatcher(int Id)
        {
            teatcherRepository.Delete(Id);
        }

        public async Task<IEnumerable<Teatcher>> GetAll()
        {
            return teatcherRepository.GetAll();
        }

        public async Task<Teatcher> UpdateTeatcher(Teatcher teatcher)
        {
            teatcherRepository.Update(teatcher);
            return teatcher;
        }
       

        public async Task<Teatcher> GetAsyncById(int Id)
        {
            return await teatcherRepository.GetAsyncById(Id);
        }
    }
}
