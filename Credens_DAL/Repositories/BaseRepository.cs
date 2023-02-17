using Credens.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

    }
}
