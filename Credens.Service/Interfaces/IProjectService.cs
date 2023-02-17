using Credens.DAL.Interfaces;
using Credens.Domain.Entity;
using Credens.Domain.Responce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.Service.Interfaces
{
    public interface IProjectService
    {
        public Task<IBaseResponce<IEnumerable<Project>>> GetProjects();
        
        public Task<IBaseResponce<Project>> GetByName(string name);

        public Task<bool> Delete(Project project);

        public Task<bool> Create (Project project);
        
        public Task<IBaseResponce<Project>> Update(Project project);
    }
}
