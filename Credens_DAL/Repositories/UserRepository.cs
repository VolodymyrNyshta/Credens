using Credens.DAL.Interfaces;
using Credens.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Linq;

namespace Credens.DAL.Repositories
{
    internal class UserRepository : IBaseRepository<User>
    {
        private readonly ApplicationContext _db;
       
        public UserRepository(ApplicationContext db) 
        {
        _db= db;
        }

        public async Task<bool> Create(User entity)
        {
            await _db.Users.AddAsync(entity);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(User entity)
        {
            _db.Users.Remove(entity);
            await _db.SaveChangesAsync();
            return true;
        }

        public IQueryable<User> GetAll()
        {
            return _db.Users;
        }

        public async Task<User> GetByName(string name)
        {
           var user = await _db.Users.FirstOrDefaultAsync(x => x.Name == name);
            if (user == null) 
            {
                throw new Exception();
            }
            return user;
     
        }

        public async Task<User> Update(User entity)
        {
            _db.Users.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
 

