using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.Domain.Responce.Interfaces
{
    public interface IBaseResponce<T>
    {
       public string Description { get; }
       public T Data { get; }   
    }
}
