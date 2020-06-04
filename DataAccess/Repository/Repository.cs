using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeatchersAndCourses.DataAccess.Context;
using TeatchersAndCourses.DataAccess.Repository.IRepository;
using Domain.Models;

namespace TeatchersAndCourses.DataAccess.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly TeatchersAndCoursesContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(TeatchersAndCoursesContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T GetById(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            if (id == 0) throw new ArgumentNullException("entity");

            T entity = entities.SingleOrDefault(s => s.Id == id);
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
