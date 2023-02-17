using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Credens.Domain;

namespace Credens.DAL.Interfaces;

public interface IBaseRepository<T>
{
    Task<bool> Create(T entity);
    Task<T> Update(T entity);
    Task<bool> Delete(T entity);
    IQueryable<T> GetAll();
    Task<T> GetByName(string name);


}
