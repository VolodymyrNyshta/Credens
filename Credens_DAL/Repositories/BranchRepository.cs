using Credens.DAL.Interfaces;
using Credens.Domain.Entity;


namespace Credens.DAL.Repositories
{
    internal class BranchRepository : IBaseRepository<Branch>
    {
        private readonly ApplicationContext _db;
        public BranchRepository(ApplicationContext db) 
        {
        _db = db;
        }

            public async Task Create(Branch entity)
            {
                await _db.Branches.AddAsync(entity);
                await _db.SaveChangesAsync();
            }

            public async Task<bool> Delete(Branch entity)
            {
                if (entity == null) 
                {
                return false;
                }
                _db.Branches.Remove(entity);
                await _db.SaveChangesAsync();
                return true;
            }

            public IQueryable<Branch> GetAll()
            {
                return _db.Branches;
            }

        public Task<Branch> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Branch> Update(Branch entity)
            {
               _db.Branches.Update(entity);
                await _db.SaveChangesAsync();
                return entity;
            }

        Task<bool> IBaseRepository<Branch>.Create(Branch entity)
        {
            throw new NotImplementedException();
        }
    }
}
