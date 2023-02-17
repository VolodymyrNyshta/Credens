using Credens.Domain.Responce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.Domain.Responce.Implementations
{
    public class BaseResponce<T> : IBaseResponce<T>
    {
        public string Description { get; set; }
        public T Data { get; set; }
    }
}
