using Credens.DAL.Interfaces;
using Credens.Domain.Entity;
using Credens.Domain.Responce.Implementations;
using Credens.Domain.Responce.Interfaces;
using Credens.Domain.ViewModels.UserViewModels;
using Credens.Service.Interfaces;


namespace Credens.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _baseRepository; 
        
        public UserService (IBaseRepository<User> baseRepository)
        {
            _baseRepository = baseRepository;      
        }
        
        public async IBaseResponce<UserViewModel> CreateUser(UserViewModel userViewModel)
        {
            BaseResponce<UserViewModel> baseResponce = new BaseResponce<UserViewModel>();
            try 
            {
                User user = new User()
                {
                    Name = userViewModel.Name,
                    LastName = userViewModel.LastName
                };
                await _baseRepository.Create(user);
                baseResponce.Data = user;
            }
            catch(Exception ex) 
            {
            
            }
        }

        public IBaseResponce<bool> DeleteUser(string name)
        {
            throw new NotImplementedException();
        }

        public IBaseResponce<User> EditUser(UserViewModel getUserByNameViewModel)
        {
            throw new NotImplementedException();
        }

        public async  Task<IBaseResponce<User>> GetUser(string name)
        {
            BaseResponce<User> baseResponce = new BaseResponce<User>();
            try
            {
               var user = await _baseRepository.GetByName(name);
               
                if (user == null) 
                {
                    baseResponce.Description = "No object!";
                    return baseResponce;
                }
               
                baseResponce.Data = user;       
                return baseResponce;
            }
            catch(Exception ex)
            {
                return new BaseResponce<User>()
                {
                    Description = ex.Message,
                };
            }
        }

        public Task<IBaseResponce<IEnumerable<User>>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
