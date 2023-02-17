using Credens.DAL.Interfaces;
using Credens.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Repositories
{
    internal class ProjectRepository : IBaseRepository<Project>
    {
        private readonly ApplicationContext _db;
        public ProjectRepository(ApplicationContext db) 
        {
            _db = db;
        }
        public async Task<bool> Create(Project entity)
        {
            await _db.Projects.AddAsync(entity);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Project entity)
        {
            if (entity == null)
            {
                return false;
            }
            _db.Projects.Remove(entity);
            await _db.SaveChangesAsync();
            return true;
        }

        public IQueryable<Project> GetAll()
        {
            return _db.Projects;
        }

        public Task<Project> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> Update(Project entity)
        {
            _db.Projects.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}
