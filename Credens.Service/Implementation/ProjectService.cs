using Credens.DAL.Interfaces;
using Credens.Domain.Entity;
using Credens.Domain.Responce.Implementations;
using Credens.Domain.Responce.Interfaces;
using Credens.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.Service.Implementation
{
    public class ProjectService : IProjectService
    {
        private readonly IBaseRepository<Project> _repository;
        public async Task<bool> Create(Project project)
        {
            var baseResponse = new BaseResponce<Project>();

            try
            {
                var _project = await _repository.Create(project);
               
                if(_project == null ) 
                {
                    baseResponse.Description = "Cant create";
                }

                baseResponse.Data = _project;

            }
            catch(Exception ex)  
            {
            
            }
        }

        public Task<bool> Delete(Project project)
        {
            throw new NotImplementedException();
        }

        public async Task<IBaseResponce<Project>> GetByName(string name)
        {
            var baseResponse = new BaseResponce<Project>();
            
            try
            {
                var project = await _repository.GetByName(name);
                if(project == null)
                {
                    baseResponse.Description = "No project";
                }
                baseResponse.Data = project;
                return baseResponse;
            }
            catch(Exception ex) 
            {
                return new BaseResponce<Project>()
                {
                    Description = ex.Message,
                };
            }
        }

        public Task<IBaseResponce<IEnumerable<Project>>> GetProjects()
        {
            var baseResponse = new BaseResponce<Project>();

            try
            {

            }
        }

        public Task<IBaseResponce<Project>> Update(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
