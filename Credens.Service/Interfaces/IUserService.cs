using Credens.Domain.Entity;
using Credens.Domain.Responce.Interfaces;
using Credens.Domain.ViewModels.UserViewModels;

namespace Credens.Service.Interfaces
{
    public interface IUserService
    {
        public IBaseResponce<IEnumerable<User>> GetUsers();

        public IBaseResponce<User> GetUser(string name);

        public IBaseResponce<User> CreateUser (User user);

        public IBaseResponce<bool> DeleteUser(string name);

        public IBaseResponce<User> EditUser(UserViewModel userViewModel);
    }
}
